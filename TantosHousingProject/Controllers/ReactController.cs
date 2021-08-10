using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TantosHousingProject.Models.Data;
using TantosHousingProject.Models.Service;
using TantosHousingProject.Models.Repo;
using TantosHousingProject.Models.ViewModel;

namespace TantosHousingProject.Controllers
{
    [EnableCors("ReactPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public class ReactController : ControllerBase
    {
        private readonly IRoomService _roomService;
        //private readonly IContractService _contractService;

        public ReactController(IRoomService roomService/* IContractService contractService*/)
        {
            _roomService = roomService;
            //_contractService = contractService;
        }

        [HttpGet]
        public List<Room> Get()
        {
            return _roomService.All().RoomList;
        }

        [HttpGet("{id}")]
        public Room GetById(int id)
        {
            Room room = _roomService.FindById(id);

            foreach (Contract contract in room.RoomHistory)
            {
                contract.RoomInQuestion = null;
            }
                  
                        return room;
        }

        [HttpPost]
        public ActionResult<Room> Create([FromBody] CreateRoomViewModel room)
        {
            //ModelState.isValid
            if (ModelState.IsValid)
            {
                return _roomService.Add(room);
            }

            return BadRequest(room);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            if (_roomService.Remove(id))
            {
                Response.StatusCode = 200;
            }
            else
            {
                Response.StatusCode = 400;
            }
        }


    }
}
