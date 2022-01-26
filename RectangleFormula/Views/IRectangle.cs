using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleFormula.Views
{
    public interface IRectangle
    {
        string PanjangText {  get; set; }
        string LebarText {  get; set; }
        string AreaText {  get; set; }
    }
}
