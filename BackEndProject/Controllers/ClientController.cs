using BackEnd.Project.DataAccess.Data;
using BackEnd.Project.DataAccess.Repository.IRepository;
using BackEnd.Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Project.Web.Controllers
{
    public class ClientController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public ClientController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }

        public IActionResult ListClient()
        {
            ViewData["Title"] = "All Clients";

            var Clients = _unitOfWork.Client.GetAll();
            return View(Clients);

        }

        [HttpGet]
        public ActionResult UniqueClient(int id)
        {
            var UniqueClient = _unitOfWork.Client.FindById(id);
            return View(UniqueClient);
        }

        public IActionResult RemoveClient(Client client)
        {

            var productToBeDeleted = _unitOfWork.Client.FindById(client.Id);

            _unitOfWork.Client.Remove(productToBeDeleted);
            _unitOfWork.Save();

            return View();
        }

        [HttpGet]
        public IActionResult CreateClient()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateClient(Client client)
        {

            _unitOfWork.Client.Add(client);



            _unitOfWork.Save();
            return View();


        }

        [HttpGet]
        public IActionResult EditClient()
        {
            return View();
        }

        public IActionResult UpdateClient(Client updatedClient)
        {
                Client existingClient = _unitOfWork.Client.FindById(updatedClient.Id);

                if (existingClient != null)
                {
                    existingClient.Name = updatedClient.Name;
                    existingClient.CPF = updatedClient.CPF;
                    existingClient.Email = updatedClient.Email;
                    existingClient.CellPhone = updatedClient.CellPhone;
                    existingClient.Street = updatedClient.Street;
                    existingClient.State = updatedClient.State;
                    existingClient.City = updatedClient.City;

                    _unitOfWork.Save();
                }
            return View(existingClient);      
        }
    }
}
