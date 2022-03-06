using System;
using System.Threading.Tasks;
using AutoMapper;
using NewsWebsite.Data.Abstract;
using NewsWebsite.Entities.Concrete;
using NewsWebsite.Entities.Dtos;
using NewsWebsite.Services.Abstract;
using NewsWebsite.Shared.Utilities.Results.Abstract;
using NewsWebsite.Shared.Utilities.Results.ComplexTypes;
using NewsWebsite.Shared.Utilities.Results.Concrete;

namespace NewsWebsite.Services.Concrete
{
    public class NewsPostManager : INewsPostService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public NewsPostManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IDataResult<NewsPostDto>> Get(int newsPostId)
        {
            var newsPost = await _unitOfWork.NewsPosts.GetAsync(n => n.Id == newsPostId, n => n.User, n => n.Category);
            if (newsPost != null)
            {
                return new DataResult<NewsPostDto>(ResultStatus.Success, new NewsPostDto
                {
                    NewsPost = newsPost,
                    ResultStatus = ResultStatus.Success
                });
            }

            return new DataResult<NewsPostDto>(ResultStatus.Error, "No such news post was found.", data: null);
        }

        public async Task<IDataResult<NewsPostListDto>> GetAll()
        {
            var newsPosts = await _unitOfWork.NewsPosts.GetAllAsync(null, n => n.User, n => n.Category);
            if (newsPosts.Count > -1)
            {
                return new DataResult<NewsPostListDto>(ResultStatus.Success, new NewsPostListDto
                {
                    NewsPosts = newsPosts,
                    ResultStatus = ResultStatus.Success
                });
            }

            return new DataResult<NewsPostListDto>(ResultStatus.Error, "News posts are not found.", data: null);
        }

        public async Task<IDataResult<NewsPostListDto>> GetAllByNonDeleted()
        {
            var newsPosts = await _unitOfWork.NewsPosts.GetAllAsync(n => !n.IsDeleted, n => n.User, n => n.Category);
            if (newsPosts.Count > -1)
            {
                return new DataResult<NewsPostListDto>(ResultStatus.Success, new NewsPostListDto
                {
                    NewsPosts = newsPosts,
                    ResultStatus = ResultStatus.Success
                });
            }

            return new DataResult<NewsPostListDto>(ResultStatus.Error, "News posts are not found.", data: null);
        }

        public async Task<IDataResult<NewsPostListDto>> GetAllByCategory(int categoryId)
        {
            var result = await _unitOfWork.Categories.AnyAsync(c => c.Id == categoryId);
            if (result)
            {
                var newsPosts =
                    await _unitOfWork.NewsPosts.GetAllAsync(n => n.CategoryId == categoryId,
                        n => !n.IsDeleted && n.IsActive, n => n.User, n => n.Category);
                if (newsPosts.Count > -1)
                {
                    return new DataResult<NewsPostListDto>(ResultStatus.Success, new NewsPostListDto
                    {
                        NewsPosts = newsPosts,
                        ResultStatus = ResultStatus.Success
                    });
                }

                return new DataResult<NewsPostListDto>(ResultStatus.Error, "News posts are not found.", data: null);
            }

            return new DataResult<NewsPostListDto>(ResultStatus.Error, "No such category was found.", data: null);
        }

        public async Task<IDataResult<NewsPostListDto>> GetAllByNonDeletedAndActive()
        {
            var newsPosts =
                await _unitOfWork.NewsPosts.GetAllAsync(n => !n.IsDeleted && n.IsActive, n => n.User, n => n.Category);
            if (newsPosts.Count > -1)
            {
                return new DataResult<NewsPostListDto>(ResultStatus.Success, new NewsPostListDto
                {
                    NewsPosts = newsPosts,
                    ResultStatus = ResultStatus.Success
                });
            }

            return new DataResult<NewsPostListDto>(ResultStatus.Error, "News posts are not found.", data: null);
        }

        public async Task<IResult> Add(NewsPostAddDto newsPostAddDto, string createdByName)
        {
            var newsPost = _mapper.Map<NewsPost>(newsPostAddDto);
            newsPost.CreatedByName = createdByName;
            newsPost.ModifiedByName = createdByName;
            newsPost.UserId = 1;
            await _unitOfWork.NewsPosts.AddAsync(newsPost).ContinueWith(t => _unitOfWork.SaveAsync());
            return new Result(ResultStatus.Success,
                $"The news post titled {newsPostAddDto.Title} has been successfully added.");
        }

        public async Task<IResult> Update(NewsPostUpdateDto newsPostUpdateDto, string modifiedByName)
        {
            var newsPost = _mapper.Map<NewsPost>(newsPostUpdateDto);
            newsPost.ModifiedByName = modifiedByName;
            await _unitOfWork.NewsPosts.UpdateAsync(newsPost).ContinueWith(t => _unitOfWork.SaveAsync());
            return new Result(ResultStatus.Success,
                $"The news post titled {newsPostUpdateDto.Title} has been successfully updated.");
        }


        public async Task<IResult> Delete(int newsPostId, string modifiedByName)
        {
            var result = await _unitOfWork.NewsPosts.AnyAsync(n => n.Id == newsPostId);
            if (result)
            {
                var newsPost = await _unitOfWork.NewsPosts.GetAsync(n => n.Id == newsPostId);
                newsPost.IsDeleted = true;
                newsPost.ModifiedByName = modifiedByName;
                newsPost.ModifiedDate = DateTime.Now;
                await _unitOfWork.NewsPosts.UpdateAsync(newsPost).ContinueWith(t => _unitOfWork.SaveAsync());
                return new Result(ResultStatus.Success,
                    $"The news post titled {newsPost.Title} has been successfully deleted.");
            }

            return new Result(ResultStatus.Error, "No such news post was found.");
        }

        public async Task<IResult> HardDelete(int newsPostId)
        {
            var result = await _unitOfWork.NewsPosts.AnyAsync(n => n.Id == newsPostId);
            if (result)
            {
                var newsPost = await _unitOfWork.NewsPosts.GetAsync(n => n.Id == newsPostId);
                await _unitOfWork.NewsPosts.UpdateAsync(newsPost).ContinueWith(t => _unitOfWork.SaveAsync());
                return new Result(ResultStatus.Success,
                    $"The news post titled {newsPost.Title} has been successfully deleted from the database.");
            }

            return new Result(ResultStatus.Error, "No such news post was found.");
        }
    }
}