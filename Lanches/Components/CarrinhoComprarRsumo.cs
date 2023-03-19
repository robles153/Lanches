using Lanches.Models;
using Lanches.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Lanches.Components
{
    public class CarrinhoComprarRsumo : ViewComponent
    {
        private readonly CarrinhoCompra _carrinhoCompra;

        public CarrinhoComprarRsumo(CarrinhoCompra carrinhoCompra)
        {
            _carrinhoCompra = carrinhoCompra;
        }

        public IViewComponentResult Invoke() 
        {
            var itens = _carrinhoCompra.GetCarrinhoCompraItens();

           /* var itens = new List<CarrinhoCompraItem>()
            {
                new CarrinhoCompraItem(),
                new CarrinhoCompraItem()

            };*/

            _carrinhoCompra.CarrinhoCompraitems = itens;

            var carrinhoCompraVM = new CarrinhoCompraViewModel
            {
                CarrinhoCompra = _carrinhoCompra,
                CarrinhoCompraTotal = _carrinhoCompra.GetcarrinhoCompraTotal()
            };

            return View(carrinhoCompraVM);

        }
    }
}
