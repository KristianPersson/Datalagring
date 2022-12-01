using _03_Inlamning.Models;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;

namespace _03_Inlamning.Views
{

   
    public partial class ErrandsView : UserControl
    {
        private SqlContext _context;
        public ErrandsView()
        {
            InitializeComponent();
            _context = new SqlContext();
            GetErrandList();
        }

        public void GetErrandList()
        {
            var errands = _context.Errands.ToList();
            var errandOverrideList = new List<ErrandOverride>();

            foreach (var errand in errands)
            {
                var errandOverride = new ErrandOverride
                {
                    ErrandName = errand.ErrandName,
                    ErrandId = errand.ErrandId,
                    ErrandDescription = errand.ErrandDescription,
                    CreateErrandDate = errand.CreateErrandDate,
                    ChangeErrandDate = errand.ChangeErrandDate,
                    ErrandStatus = errand.ErrandStatus,

                };

                errandOverrideList.Add(errandOverride);
            }

            ErrandListView.ItemsSource = errandOverrideList;
        }


    }
   
}

public class ErrandOverride
{
    public int ErrandId { get; set; }

    public string ErrandName { get; set; } = null!;

    public string ErrandDescription { get; set; } = null!;

    public int CreateErrandDate { get; set; }

    public int ChangeErrandDate { get; set; }

    public string ErrandStatus { get; set; } = null!;

    public override string ToString()
    {
        return
            this.ErrandName + ", " +
            this.ErrandId + ", " +
            this.ErrandDescription + ", " +
            this.CreateErrandDate + ", " +
            this.ChangeErrandDate + ", " +
            this.ErrandStatus;
    }

}





