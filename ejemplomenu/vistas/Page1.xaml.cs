using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ejemplomenu.vistas;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ejemplomenu.vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : MasterDetailPage
    {
        public Page1()
        {
            InitializeComponent();
            this.Master = new Nav();
            this.Detail = new NavigationPage(new Inicio());
            App.MasterDet = this;



        }
    }
}