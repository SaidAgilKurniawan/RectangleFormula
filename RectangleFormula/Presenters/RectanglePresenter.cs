using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RectangleFormula.Views;
using RectangleFormula.Models;

namespace RectangleFormula.Presenters
{
    public class RectanglePresenter
    {
        IRectangle rectangleView;
        public RectanglePresenter(IRectangle view)
        {
            rectangleView = view;
        }
        public void CalculateArea()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Panjang = double.Parse(rectangleView.PanjangText);
            rectangle.Lebar = double.Parse(rectangleView.LebarText);

            rectangleView.AreaText = rectangle.CalculateArea().ToString();
        }
    }
}
