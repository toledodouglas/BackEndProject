using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Project.Models
{
    public class Cart : Entity
    {
        public List<CartProduct> Products { get; set; }

        public Status Status { get; set; }

        public decimal GetTotalPrice() {
            return 0;
            //Interar lista de CartProduct para interar a soma dos produtos
        }
        public void SetStatusAberto() {
            
            SetStatusDesejado(Status.Aberto);
        }
        public void SetStatus()
        {
            //this.Status = Status.Processando;
            SetStatusDesejado(Status.Processando);
        }

        public void SetStatusPage()
        {
            SetStatusDesejado(Status.Pago);
        }

        public void SetStatusConcluido()
        {
            SetStatusDesejado(Status.Concluido);
        }

        public void SetStatusCancelado()
        {
            SetStatusDesejado(Status.Cancelado);
        }

        public void SetStatusDesejado(Status status)
        {
            this.Status = status;
        }

    }

    public class CartProduct : Entity
    {
        public int CartId { get; set; }

        public int ProductId { get; set; }

        public decimal Price { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Quantity { get; set; }
    }

    public enum Status
    {
        Aberto,
        Processando,
        Pago,
        Concluido,
        Cancelado,
    }
}
