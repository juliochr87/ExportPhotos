using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExportPhotos
{
    public class IntegerComparer : IComparer
    {
        private int _colIndex;
        public IntegerComparer(int colIndex)
        {
            _colIndex = colIndex;
        }
        public int Compare(object x, object y)
        {

            int nx = 0;
            int ny = 0;

            try
            {
                nx = int.Parse((x as ListViewItem).SubItems[_colIndex].Text);
            }
            catch
            {

            }

            try
            {
               ny = int.Parse((y as ListViewItem).SubItems[_colIndex].Text);
            }
            catch
            {

            }
 
                return nx.CompareTo(ny);
      
        }
    }
}
