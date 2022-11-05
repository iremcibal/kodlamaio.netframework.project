using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Concrete;
using Business.Profiles;
using Business.Request.Product;
using Business.Response.Product;
using DataAccess.Abstract;
using DataAccess.Concrete.Adonet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsUI
{
    public partial class ProductForm : Form
    {
        IProductService _productService;
        private ListProductResponse selectedProduct;
        public ProductForm()
        {
            IProductDal _productDal = new AdoProductDal();
            
            ProductMapperProfiles productMapperProfiles = new ProductMapperProfiles();
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(productMapperProfiles);
            });

            IMapper mapper = new Mapper(mapperConfig);

            _productService = new
                ProductManager(_productDal,
                new ProductBusinessRules(_productDal),
                mapper);



            InitializeComponent();
        }

       
       
        private void Add_Click(object sender, EventArgs e)
        {
            CreateProductRequest createProductRequest = new CreateProductRequest()
            {
                Name = ProductNameTb.Text,
                CategoryID = CategoryIDTb.Text,
                UnitPrice = UnitPriceTb.Text,
                UnitsInStock = UnitsInStockTb.Text,
                
            };

            _productService.Add(createProductRequest);
            MessageBox.Show("Ekleme Başarılı", "Sistem");
            getAll();
        }
        private void ProductForm_Load(object sender, EventArgs e)
        {
            getAll();
            
        }

        private void getAll()
        {
            List<ListProductResponse> products = _productService.GetAll();
            ProductGridView.DataSource = products;
        }
        private void productsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (ProductGridView.SelectedRows.Count <= 0) return;
            var firstlySelectedRow = ProductGridView.SelectedRows[0];
           // Console.WriteLine(firstlySelectedRow.Cells["Name"].Value);



            ProductNameUpdateTb.Text = firstlySelectedRow.Cells["Name"].Value.ToString();
            CategoryIDUpdateTb.Text = firstlySelectedRow.Cells["CategoryID"].Value.ToString();
            UnitPriceUpdateTb.Text = firstlySelectedRow.Cells["UnitPrice"].Value.ToString();
            UnitsInStockUpdateTb.Text = firstlySelectedRow.Cells["UnitsInStock"].Value.ToString();

            ProductNameDeleteTb.Text = firstlySelectedRow.Cells["Name"].Value.ToString();
            CategoryIDDeleteTb.Text = firstlySelectedRow.Cells["CategoryID"].Value.ToString();
            UnitPriceDeleteTb.Text = firstlySelectedRow.Cells["UnitPrice"].Value.ToString();
            UnitsInStockDeleteTb.Text = firstlySelectedRow.Cells["UnitsInStock"].Value.ToString();

        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (ProductGridView.SelectedRows.Count <= 0) return;
            UpdateProductRequest updateProductRequest = new UpdateProductRequest()
            {
                Name = ProductNameUpdateTb.Text,
                CategoryID = CategoryIDUpdateTb.Text,
                UnitPrice = UnitPriceUpdateTb.Text,
                UnitsInStock = UnitsInStockUpdateTb.Text,
                ID = int.Parse(ProductGridView.SelectedRows[0].Cells[0].Value.ToString())
            };
            _productService.Update(updateProductRequest);
            MessageBox.Show("Güncelleme Başarılı", "Sistem");
            getAll();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if(ProductGridView.SelectedRows.Count <= 0) return;
            DeleteProductRequest deleteProductRequest = new DeleteProductRequest()
            {
                Id = int.Parse(ProductGridView.SelectedRows[0].Cells[0].Value.ToString())
            };
            _productService.Delete(deleteProductRequest);
            MessageBox.Show("Silme İşlemi Başarılı", "Sistem");
            getAll();
        }
    }
}
