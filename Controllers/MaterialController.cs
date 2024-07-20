using ApiMateriais.Dto;
using ApiMateriais.Exceptions;
using ApiMateriais.Models;
using ApiMateriais.Service;
using ApiMateriais.Util;
using Microsoft.AspNetCore.Mvc;

namespace ApiMateriais.Controllers;

[ApiController]
[Route("materiais")]
public class MaterialController : ControllerBase
{
    private readonly MaterialService _materialService = new MaterialService();
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(new ResponseDto("", Constantes.STATUS_OK, _materialService.GetAll()));
    }

    [HttpGet("{id}")]
    public IActionResult Get(Guid id)
    {
        Material material = _materialService.GetById(id);
        if(material != null)
            return Ok(new ResponseDto("", Constantes.STATUS_OK, material));
        
        return NotFound(new ResponseDto("Nenhum material encontrado.", Constantes.STATUS_ERRO));
    }

    [HttpPost]
    public IActionResult Create([FromBody]MaterialDto materialDto)
    {
        _materialService.Create(materialDto.name, materialDto.quantidade);
        return Created();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        try
        {
            _materialService.Delete(id);
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
            _materialService.Update(id, material.name);
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
