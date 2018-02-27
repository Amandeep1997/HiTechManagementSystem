using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryFinal.DAL;

namespace ClassLibraryFinal.BUI
{
  public  class Software
    {
        public int SoftwareId { get; set; }
        public string SoftwareName { get; set; }

        public bool addsoftware(Software software)
        {
            return ProductDB.saveSoftware(software);
        }
        public Software searchSoftware(int softwareId)
        {
            return ProductDB.Searchsoftware(softwareId);
        }
        public List<Software> listSoftware()
        {
            return ProductDB.listsoftware();
        }
        public void DeleteSoftware(Software soft)
        {
            ProductDB.DeleteSoftware(soft);
        }
        public void UpdateSoftware(Software soft)
        {
            ProductDB.UpdateSoftware(soft);
        }
    }

}
