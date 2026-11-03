using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using EntitiesLayer;
using LogicLayer;

namespace PresentationLayer
{
    public partial class MainForm : Form
    {
        private const string InvalidInput = "Hatalı giriş.";
        private const string MissingId = "Hatalı giriş \nDüzenlenecek verinin ID'sini girmeyi unutmayınız.";
        private const string MissingDeleteId = "Silinecek verinin ID'sini giriniz";

        private readonly User currentUser;
        private readonly List<Product> cart = new List<Product>();
        private decimal cashTotal;
        private decimal cardTotal;
        private decimal checkTotal;

        public MainForm(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            listCart.View = View.Details;
            listCart.GridLines = true;
            listCart.FullRowSelect = true;
            listCart.Columns.Add("ID", 30);
            listCart.Columns.Add("ÜRÜN ADI", 130);
            listCart.Columns.Add("ÜRÜN FİYATI", 85);

            Run(InvalidInput, () =>
            {
                LoadCustomers();
                LoadDailyReports();
                LoadProducts();
                LoadCategories();
                LoadSuppliers();
                LoadBrands();
                LoadUnits();
                LoadUsers();
            });
            ApplyPermissions();
        }

        private void ApplyPermissions()
        {
            if (currentUser.IsAdmin)
            {
                Text = "Market Otomasyonu (admin)";
                return;
            }

            Text = "Market Otomasyonu (personel)";
            foreach (var tab in new[] { tabUsers, tabUnits, tabBrands, tabSuppliers, tabCategories, tabProducts })
            {
                tabControl.TabPages.Remove(tab);
            }
            txtCashTotal.Enabled = false;
            txtCardTotal.Enabled = false;
            txtCheckTotal.Enabled = false;
            txtRevenue.Enabled = false;
            btnUpdateDailyReport.Enabled = false;
            btnDeleteDailyReport.Enabled = false;
        }

        private static void Run(string errorMessage, Action action)
        {
            try
            {
                action();
            }
            catch (FormatException)
            {
                MessageBox.Show(errorMessage);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Veritabanı hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void AfterSave(bool saved, Action refresh)
        {
            if (saved)
            {
                refresh();
            }
            else
            {
                MessageBox.Show(InvalidInput);
            }
        }

        private static int ReadInt(TextBox box) => int.Parse(box.Text.Trim());

        private static decimal ReadDecimal(TextBox box) => decimal.Parse(box.Text.Trim());

        private static int SelectedId(ComboBox box) => box.SelectedValue is int id ? id : throw new FormatException();

        private static void Bind(ComboBox box, object items)
        {
            box.DisplayMember = "Name";
            box.ValueMember = "Id";
            box.DataSource = items;
        }

        private void LoadUsers() => gridUsers.DataSource = LogicProcess.GetUsers();

        private void btnAddUser_Click(object sender, EventArgs e) => Run(InvalidInput, () =>
            AfterSave(LogicProcess.AddUser(txtUsername.Text, txtPassword.Text, chkIsAdmin.Checked), LoadUsers));

        private void btnUpdateUser_Click(object sender, EventArgs e) => Run(InvalidInput, () =>
            AfterSave(LogicProcess.UpdateUser(ReadInt(txtUserId), txtUsername.Text, txtPassword.Text, chkIsAdmin.Checked), LoadUsers));

        private void btnDeleteUser_Click(object sender, EventArgs e) => Run(InvalidInput, () =>
        {
            var id = ReadInt(txtUserId);
            if (id == currentUser.Id)
            {
                MessageBox.Show("Kendi hesabınızı silemezsiniz.");
                return;
            }
            LogicProcess.DeleteUser(id);
            LoadUsers();
        });

        private void LoadUnits()
        {
            gridUnits.DataSource = LogicProcess.GetUnits();
            Bind(cmbUnit, LogicProcess.GetUnits());
        }

        private void btnAddUnit_Click(object sender, EventArgs e) => Run(InvalidInput, () =>
            AfterSave(LogicProcess.AddUnit(new Unit { Name = txtUnitName.Text }), LoadUnits));

        private void btnUpdateUnit_Click(object sender, EventArgs e) => Run(MissingId, () =>
            AfterSave(LogicProcess.UpdateUnit(new Unit { Id = ReadInt(txtUnitId), Name = txtUnitName.Text }), () => { LoadUnits(); LoadProducts(); }));

        private void btnDeleteUnit_Click(object sender, EventArgs e) => Run(MissingDeleteId, () =>
        {
            LogicProcess.DeleteUnit(ReadInt(txtUnitId));
            LoadUnits();
            LoadProducts();
        });

        private void LoadCategories()
        {
            gridCategories.DataSource = LogicProcess.GetCategories();
            Bind(cmbCategory, LogicProcess.GetCategories());
        }

        private Category ReadCategory(int id = 0) =>
            new Category { Id = id, Name = txtCategoryName.Text, VatRate = ReadInt(txtVatRate) };

        private void btnAddCategory_Click(object sender, EventArgs e) => Run(InvalidInput, () =>
            AfterSave(LogicProcess.AddCategory(ReadCategory()), LoadCategories));

        private void btnUpdateCategory_Click(object sender, EventArgs e) => Run(MissingId, () =>
            AfterSave(LogicProcess.UpdateCategory(ReadCategory(ReadInt(txtCategoryId))), () => { LoadCategories(); LoadProducts(); }));

        private void btnDeleteCategory_Click(object sender, EventArgs e) => Run(MissingDeleteId, () =>
        {
            LogicProcess.DeleteCategory(ReadInt(txtCategoryId));
            LoadCategories();
            LoadProducts();
        });

        private void LoadBrands()
        {
            gridBrands.DataSource = LogicProcess.GetBrands();
            Bind(cmbBrand, LogicProcess.GetBrands());
        }

        private void btnAddBrand_Click(object sender, EventArgs e) => Run(InvalidInput, () =>
            AfterSave(LogicProcess.AddBrand(new Brand { Name = txtBrandName.Text }), LoadBrands));

        private void btnUpdateBrand_Click(object sender, EventArgs e) => Run(MissingId, () =>
            AfterSave(LogicProcess.UpdateBrand(new Brand { Id = ReadInt(txtBrandId), Name = txtBrandName.Text }), () => { LoadBrands(); LoadProducts(); }));

        private void btnDeleteBrand_Click(object sender, EventArgs e) => Run(MissingDeleteId, () =>
        {
            LogicProcess.DeleteBrand(ReadInt(txtBrandId));
            LoadBrands();
            LoadProducts();
        });

        private void LoadSuppliers()
        {
            gridSuppliers.DataSource = LogicProcess.GetSuppliers();
            Bind(cmbSupplier, LogicProcess.GetSuppliers());
        }

        private Supplier ReadSupplier(int id = 0) =>
            new Supplier { Id = id, Name = txtSupplierName.Text, Address = txtSupplierAddress.Text, Phone = txtSupplierPhone.Text };

        private void btnAddSupplier_Click(object sender, EventArgs e) => Run(InvalidInput, () =>
            AfterSave(LogicProcess.AddSupplier(ReadSupplier()), LoadSuppliers));

        private void btnUpdateSupplier_Click(object sender, EventArgs e) => Run(MissingId, () =>
            AfterSave(LogicProcess.UpdateSupplier(ReadSupplier(ReadInt(txtSupplierId))), () => { LoadSuppliers(); LoadProducts(); }));

        private void btnDeleteSupplier_Click(object sender, EventArgs e) => Run(MissingDeleteId, () =>
        {
            LogicProcess.DeleteSupplier(ReadInt(txtSupplierId));
            LoadSuppliers();
            LoadProducts();
        });

        private void LoadCustomers() => gridCustomers.DataSource = LogicProcess.GetCustomers();

        private Customer ReadCustomer(int id = 0) => new Customer
        {
            Id = id,
            NationalId = txtCustomerNationalId.Text,
            Name = txtCustomerName.Text,
            Address = txtCustomerAddress.Text,
            Phone = txtCustomerPhone.Text
        };

        private void btnAddCustomer_Click(object sender, EventArgs e) => Run(InvalidInput, () =>
            AfterSave(LogicProcess.AddCustomer(ReadCustomer()), LoadCustomers));

        private void btnUpdateCustomer_Click(object sender, EventArgs e) => Run(MissingId, () =>
            AfterSave(LogicProcess.UpdateCustomer(ReadCustomer(ReadInt(txtCustomerId))), LoadCustomers));

        private void btnDeleteCustomer_Click(object sender, EventArgs e) => Run(MissingDeleteId, () =>
        {
            LogicProcess.DeleteCustomer(ReadInt(txtCustomerId));
            LoadCustomers();
        });

        private void btnSearchCustomerByName_Click(object sender, EventArgs e) => Run(InvalidInput, () =>
            gridCustomers.DataSource = LogicProcess.SearchCustomersByName(txtSearchName.Text));

        private void btnSearchCustomerByPhone_Click(object sender, EventArgs e) => Run(InvalidInput, () =>
            gridCustomers.DataSource = LogicProcess.SearchCustomersByPhone(txtSearchPhone.Text));

        private void LoadProducts()
        {
            gridProducts.DataSource = LogicProcess.GetProducts();
            gridSaleProducts.DataSource = LogicProcess.GetProducts();
        }

        private Product ReadProduct(int id = 0) => new Product
        {
            Id = id,
            Code = txtCode.Text,
            Description = txtDescription.Text,
            SalePrice = ReadDecimal(txtSalePrice),
            PurchasePrice = ReadDecimal(txtPurchasePrice),
            Stock = ReadInt(txtStock),
            UnitId = SelectedId(cmbUnit),
            CategoryId = SelectedId(cmbCategory),
            BrandId = SelectedId(cmbBrand),
            SupplierId = SelectedId(cmbSupplier)
        };

        private void btnAddProduct_Click(object sender, EventArgs e) => Run(InvalidInput, () =>
            AfterSave(LogicProcess.AddProduct(ReadProduct()), () => { LoadProducts(); MessageBox.Show("Ürün Eklendi"); }));

        private void btnUpdateProduct_Click(object sender, EventArgs e) => Run(MissingId, () =>
            AfterSave(LogicProcess.UpdateProduct(ReadProduct(ReadInt(txtProductId))), () => { LoadProducts(); MessageBox.Show("Ürün düzenlendi"); }));

        private void btnDeleteProduct_Click(object sender, EventArgs e) => Run(MissingDeleteId, () =>
        {
            LogicProcess.DeleteProduct(ReadInt(txtProductId));
            LoadProducts();
            MessageBox.Show("Ürün silindi");
        });

        private void btnSearchByCode_Click(object sender, EventArgs e) => Run(InvalidInput, () =>
            gridSaleProducts.DataSource = LogicProcess.SearchProductsByCode(txtSearchCode.Text));

        private void btnSearchByDescription_Click(object sender, EventArgs e) => Run(InvalidInput, () =>
            gridSaleProducts.DataSource = LogicProcess.SearchProductsByDescription(txtSearchDescription.Text));

        private void UpdateCartTotal() => txtCartTotal.Text = cart.Sum(p => p.SalePrice).ToString();

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (!(gridSaleProducts.CurrentRow?.DataBoundItem is Product product))
            {
                MessageBox.Show("Ürün seçiniz.");
                return;
            }
            cart.Add(product);
            listCart.Items.Add(new ListViewItem(new[] { product.Id.ToString(), product.Description, product.SalePrice.ToString() }));
            UpdateCartTotal();
        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (listCart.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Ürün seçiniz.");
                return;
            }
            var index = listCart.SelectedIndices[0];
            cart.RemoveAt(index);
            listCart.Items.RemoveAt(index);
            UpdateCartTotal();
        }

        private void btnCompleteSale_Click(object sender, EventArgs e) => Run(InvalidInput, () =>
        {
            if (cart.Count == 0)
            {
                MessageBox.Show("Sepet boş.");
                return;
            }
            if (!rdoCash.Checked && !rdoCard.Checked && !rdoCheck.Checked)
            {
                MessageBox.Show("Satış türü seçiniz.");
                return;
            }

            var total = cart.Sum(p => p.SalePrice);
            if (rdoCash.Checked && decimal.TryParse(txtReceivedAmount.Text, out var received))
            {
                txtChange.Text = (received - total).ToString();
            }

            var answer = MessageBox.Show("Sepeti tamamlamak istiyor musunuz?", "SEPET ONAY", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (answer != DialogResult.Yes)
            {
                return;
            }
            if (!LogicProcess.CompleteSale(cart))
            {
                MessageBox.Show("Yetersiz stok.");
                return;
            }

            if (rdoCash.Checked) cashTotal += total;
            else if (rdoCard.Checked) cardTotal += total;
            else checkTotal += total;

            cart.Clear();
            listCart.Items.Clear();
            txtReceivedAmount.Text = "";
            txtChange.Text = "";
            txtCartTotal.Text = "";
            LoadProducts();
        });

        private void rdoCash_CheckedChanged(object sender, EventArgs e) => grpCashPayment.Enabled = true;

        private void rdoCard_CheckedChanged(object sender, EventArgs e) => grpCashPayment.Enabled = false;

        private void rdoCheck_CheckedChanged(object sender, EventArgs e) => grpCashPayment.Enabled = false;

        private void LoadDailyReports() => gridDailyReports.DataSource = LogicProcess.GetDailyReports();

        private void btnEndDay_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("Günü bitirmek istediğinizden emin misiniz?", "Gün Sonu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (answer != DialogResult.Yes)
            {
                return;
            }

            txtReportDate.Text = DateTime.Today.ToString("d");
            txtCashTotal.Text = cashTotal.ToString();
            txtCardTotal.Text = cardTotal.ToString();
            txtCheckTotal.Text = checkTotal.ToString();
            txtRevenue.Text = (cashTotal + cardTotal + checkTotal).ToString();
            Run(InvalidInput, LoadDailyReports);

            foreach (var tab in tabControl.TabPages.Cast<TabPage>().Where(t => t != tabDailyReports).ToList())
            {
                tabControl.TabPages.Remove(tab);
            }
        }

        private DailyReport ReadDailyReport(int id = 0) => new DailyReport
        {
            Id = id,
            ReportDate = DateTime.Parse(txtReportDate.Text),
            CardTotal = ReadDecimal(txtCardTotal),
            CashTotal = ReadDecimal(txtCashTotal),
            CheckTotal = ReadDecimal(txtCheckTotal),
            Revenue = ReadDecimal(txtRevenue)
        };

        private void btnSaveDailyReport_Click(object sender, EventArgs e) => Run(InvalidInput, () =>
        {
            var report = ReadDailyReport();
            if (LogicProcess.DailyReportExists(report.ReportDate))
            {
                MessageBox.Show("Aynı günü tekrar ekliyorsunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            LogicProcess.AddDailyReport(report);
            LoadDailyReports();
        });

        private void btnUpdateDailyReport_Click(object sender, EventArgs e) => Run(InvalidInput, () =>
        {
            LogicProcess.UpdateDailyReport(ReadDailyReport(ReadInt(txtReportId)));
            LoadDailyReports();
        });

        private void btnDeleteDailyReport_Click(object sender, EventArgs e) => Run("Silinecek günün ID bilgisini giriniz.", () =>
        {
            LogicProcess.DeleteDailyReport(ReadInt(txtReportId));
            LoadDailyReports();
        });

        private void exitMenuItem_Click(object sender, EventArgs e) => Close();
    }
}
