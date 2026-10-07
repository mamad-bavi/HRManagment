using Application.DTOs.Base;
using Domain.Entities.Base;
using GenericRepository.Contracts.Generic;
using GenericRepository.Filters;
using GenericRepository.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HRManagment.Api
{
    [ApiVersion("1")]
    public class CrudController<TDto,TDtoSelect,Tentity> : BaseController
        where TDto : BaseDto, new()
        where TDtoSelect : BaseDto, new()
        where Tentity : BaseEntity, new()
    {

        private readonly IRepositoryPublicAsyncDtoEFCore<Tentity,TDto> repository;

        public CrudController(IRepositoryPublicAsyncDtoEFCore<Tentity,TDto> repository)
        {
            this.repository = repository;
        }

        // GET: api/<UsersController>
        [HttpGet]
        public virtual async Task<GreadData<TDto>> Get(CancellationToken cancellationToken)
        => await repository.GetDtos(cancellationToken);
        

        [HttpGet]
        public virtual async Task<ActionResult<List<TDto>>> GetDeleted(CancellationToken cancellationToken)
        {
            var result = await repository.TableNoTrackingDeleted.ToListAsync(cancellationToken);
            if (result == null || result.Count == 0) return NotFound();

            return Ok(result.ConvertListObject<TDto,Tentity>());
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]

        public virtual async Task<GreadData<TDto>> Get(long id, CancellationToken cancellationToken)
         => await repository.GetDtos(c => c.Id == id, cancellationToken);
           

        [HttpGet("{id}")]

        public virtual async Task<ActionResult<TDto>> GetDeleted(long id, CancellationToken cancellationToken)
        {
            var result = (await repository
                .GetByIdDeletedAsync(cancellationToken, id));
            if (result == null) return NotFound();
            return Ok(result);
        }

        // POST api/<UsersController>
        [HttpPost]

        public virtual async Task<ActionResult<TDto>> Add(TDto dto, CancellationToken cancellationToken)
        {
            if (ModelState.IsValid)
            {
                var entity = dto.ConvertObject<Tentity, TDto>();
                await repository.AddAsync(entity, cancellationToken);
                return Ok(dto);
            }
            return BadRequest();
        }
        



        // PUT api/<UsersController>/5
        [HttpPut]

        public virtual async Task<ActionResult<TDto>> Update(TDto dto, CancellationToken cancellationToken)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var entity = dto.ConvertObject<Tentity, TDto>();
            await repository.UpdateAsync(entity, cancellationToken);
            return Ok(dto);
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]

        public virtual async Task<ActionResult> Delete(long id, CancellationToken cancellationToken)
        {
            var entity = await repository.GetByIdAsync(cancellationToken, id);
            await repository.DeleteAsync(entity, cancellationToken);
            return Ok();
        }
    }

    public class CrudController<TDto, Tentity> : CrudController<TDto, TDto, Tentity>
        where TDto : BaseDto, new()
        where Tentity : BaseEntity, new()
    {
        public CrudController(IRepositoryPublicAsyncDtoEFCore<Tentity,TDto> repository)
            : base( repository)
        {
        }
    }

}
