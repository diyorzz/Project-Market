﻿using DiyorMarket.Domain.DTOs.Sale;
using DiyorMarket.Domain.DTOs.Supply;
using DiyorMarket.Domain.Enterfaces.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DiyorMarket.Controllers
{
    [Route("api/supplies")]
    [ApiController]
    public class SuppliesController : ControllerBase
    {
        private readonly ISupplyService _supplyService;
        public SuppliesController(ISupplyService supplyService)
        {
            _supplyService = supplyService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<SupplyDTOs>> Get()
        {
            var supplies= _supplyService.GetSupply();

            return Ok(supplies);
        }

        [HttpGet("{id}")]
        public ActionResult<SupplyDTOs> Get(int id)
        {
            var supply=_supplyService.GetSupplyById(id);

            return Ok(supply);
        }

        [HttpPost]
        public ActionResult<SaleDTOs> Post([FromBody] SupplyForCreateDTOs supply)
        {
            _supplyService.CreateSupply(supply);
            return StatusCode(201);
        }

        // PUT api/<SuppliesController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] SupplyForUpdateDTOs supply)
        {
            _supplyService.UpdateSupply(supply);
            return NoContent();
        }

        // DELETE api/<SuppliesController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _supplyService?.DeleteSupply(id);
            return NoContent();
        }
    }
}
