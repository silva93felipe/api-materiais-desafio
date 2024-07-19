using ApiMateriais.Dto;
using ApiMateriais.Models;
using ApiMateriais.Service;
using Microsoft.AspNetCore.Mvc;

namespace ApiMateriais.Controllers;

[ApiController]
[Route("materiais")]
public class MaterialController : ControllerBase
{
    private readonly MaterialService _materialService = new MaterialService();
    [HttpGet]
    public IEnumerable<Material> GetAll()
    {
        return _materialService.GetAll();
    }

    [HttpGet("{id}")]
    public Material Get(Guid id)
    {
        return _materialService.GetById(id);
    }

    [HttpPost]
    public void Create([FromBody]MaterialDto materialDto)
    {
        _materialService.Create(materialDto.name, materialDto.quantidade);
    }

    [HttpDelete]
    public void Delete(Guid id)
    {
        _materialService.Delete(id);
    }

    
    [HttpPut]
    public void Update(Guid id, MaterialDto material)
    {
    }
}
