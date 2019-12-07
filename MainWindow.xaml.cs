using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace dotNet5780_03_8772_9333
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Host currentHost;
        private List<Host> hostsList;
        public MainWindow()
        {
            InitializeComponent();
            hostsList = new List<Host>()
            {
                new Host()
                {
                    HostName="HodayaAndShir",
                    Units=new List<HostingUnit>()
                    {
                        new HostingUnit()
                        {
                            UnitName="גפן",
                            Rooms=3,
                            IsSwimmimgPool=true,
                            AllOrders=new List<DateTime>(),
                            Uris = new List<string>()
                            {
                                "https://my.weekend.co.il/Templates/customerimages/26043/gallery/image_26043_d87ea0ed995344eca413805a0eadf8b0.jpg?w=1028&h=510&mode=crop&quality=70",
                                "http://www.zimmer.co.il/gaston/IMG_5527.jpg"
                            }
                        },
                        new HostingUnit()
                        {
                            UnitName="חיטה",Rooms=2,IsSwimmimgPool=false,AllOrders= new List<DateTime>(),
                            Uris=new List<string>()
                            { "https://img.mako.co.il/2014/04/07/biktot04_c.jpg",
                                "https://www.seaofgalileehotels.co.il/wp-content/uploads/2019/05/Beautiful-Lake-View-Wooden-House.jpg"
                            }
                        },
                        new HostingUnit()
                        {
                            UnitName="רימון",Rooms=3,IsSwimmimgPool=true,AllOrders= new List<DateTime>(),
                            Uris=new List<string>()
                            { "https://places.weekend.co.il/Templates/25273/p_25273_27.jpg",
                                "https://www.zimertop.co.il/gallery/14804064099_400x300.jpg"
                            }
                        },
                    },
                },
                new Host()
                {
                    HostName="GeekHouse",
                    Units=new List<HostingUnit>()
                    {
                        new HostingUnit()
                        {
                            UnitName="היפרבולה",
                            Rooms=3,
                            IsSwimmimgPool=true,
                            AllOrders=new List<DateTime>(),
                            Uris = new List<string>()
                            {
                                "https://www.creme.co.il/gallery/14664249697_600x500.jpg",
                                "https://edenss.co.il/wp-content/uploads/2019/07/EDENS_BOUTIQUE_6170_0-1-e1564519222821.jpg"
                            }
                        },
                        new HostingUnit()
                        {
                            UnitName="אסימפטוטה",
                            Rooms =2,
                            IsSwimmimgPool =false,
                            AllOrders = new List<DateTime>(),
                            Uris=new List<string>()
                            {
                                "https://www.zimerim.org.il/Editor/assets/shutterstock_22066402.jpg",
                                "https://images.hapisga.co.il/production/styles/hapisga_gallery_reduced_quality/s3/sites/12465/Albert-9347_0.jpg",
                                "https://hitrashmut.co.il/wp-content/themes/patterns/timthumb.php?src=https%3A%2F%2Fhitrashmut.co.il%2Fwp-content%2Fuploads%2F2014%2F07%2F8802149.jpg&q=90&w=650&h=300&zc=1"
                            }
                        },

                    },
                },
                new Host()
                {
                    HostName="FoodFactory",
                    Units=new List<HostingUnit>()
                    {
                        new HostingUnit()
                        {
                            UnitName="שוקולד ציפס",
                            Rooms=3,
                            IsSwimmimgPool=true,
                            AllOrders=new List<DateTime>(),
                            Uris = new List<string>()
                            { "https://www.cnaan-village.co.il/sysvault/docsfiles9/cd635817344317278294.jpg",
                                "https://www.zimerzugi.co.il/gallery/1479120353_800x600.jpg",
                            "https://www.zimmersdaka90.co.il/gallery_v4u/v4u_1564601399175295_600x300.jpeg"
                            }
                        },
                        new HostingUnit()
                        {
                            UnitName="פוקפורן מתוק",
                            Rooms =2,
                            IsSwimmimgPool =false,
                            AllOrders = new List<DateTime>(),
                            Uris=new List<string>(){
                                "https://img.mako.co.il/2014/04/07/biktot04_c.jpg",
                                "https://www.seaofgalileehotels.co.il/wp-content/uploads/2019/05/Beautiful-Lake-View-Wooden-House.jpg",
                                "https://www.creme.co.il/gallery/15306132128_600x500.jpg"
                            }
                        },
                        new HostingUnit()
                        {
                            UnitName="שוקו חם  עם מרשמלו",
                             Rooms =2,
                             IsSwimmimgPool =true,
                             AllOrders = new List<DateTime>(),
                            Uris=new List<string>()
                            {
                                "https://portalraz.co.il/wp-content/uploads/2017/08/manor-house-2359884_640-960x540.jpg",
                                "https://www.zimertop.co.il/gallery/14804064099_400x300.jpg"
                            }
                        },
                    },
                  },
            };
            cbHostList.ItemsSource = hostsList;
            cbHostList.DisplayMemberPath = "HostName";
            cbHostList.SelectedIndex = 0;

        }

        private void InitializeHost(int index)
        {
            MainGrid.Children.RemoveRange(1, 3);
            currentHost = hostsList[index];
            UpGrid.DataContext = currentHost;
            for (int i = 0; i < currentHost.Units.Count; i++)
            {
                HostingUnitUserControl a = new HostingUnitUserControl(currentHost.Units[i]);
                MainGrid.Children.Add(a);
                Grid.SetRow(a, i + 1);
            }
        }
        private void CbHostList1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            InitializeHost(cbHostList.SelectedIndex);
        }
    }
}
