using ApiMateriais.Dto;
using ApiMateriais.Exceptions;
using ApiMateriais.Models;
using ApiMateriais.Service;
using ApiMateriais.Util;
using Microsoft.AspNetCore.Mvc;

namespace ApiMateriais.Controllers;

[ApiController]
[Route("materiais")]
public class OrdemController : ControllerBase
{    
    private readonly OrdemService _ordemService = new OrdemService();
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(new ResponseDto("", Constantes.STATUS_OK));
    }

    [HttpGet("{id}")]
    public IActionResult Get(Guid id)
    {
        return NotFound(new ResponseDto("Nenhum material encontrado.", Constantes.STATUS_ERRO));
    }

    [HttpPost]
    public IActionResult Create([FromBody]MaterialDto materialDto)
    {
        return Created();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        try
        {
            
            return NoContent();
        }
        catch (MaterialNotFoundException err)
        {
            return BadRequest(new ResponseDto(err.Message, Constantes.STATUS_ERRO));
        }
        catch (Exception err)
        {
            return BadRequest(new ResponseDto("Houve um problema no momento. Tente novamente mais tarde", Constantes.STATUS_ERRO));
        }
    }

    [HttpPut("{id}")]
    public IActionResult Update(Guid id, [FromBody]MaterialDto material)
    {
        try
        {
            return NoContent();
        }
        catch (MaterialNotFoundException err)
        {
            return BadRequest(new ResponseDto(err.Message, Constantes.STATUS_ERRO));
        }
        catch (Exception err)
        {
            return BadRequest(new ResponseDto("Houve um problema no momento. Tente novamente mais tarde", Constantes.STATUS_ERRO));
        }
    }
}
