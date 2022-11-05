using AutoMapper;
using Business.Abstract;
using Business.Concrete;
using Business.Profiles;
using Business.Request.Customer;
using Business.Response.Customer;
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
    public partial class CustomerForm : Form
    {
        ICustomerService _customerService;
        public CustomerForm()
        {
            ICustomerDal _customerDal = new AdoCustomerDal();
            CustomerMapperProfiles _customerMapper = new CustomerMapperProfiles();
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(_customerMapper);
            });

            IMapper mapper = new Mapper(mapperConfig);

            _customerService = new
                CustomerManager(_customerDal, mapper);


            InitializeComponent();
        }

        private void GetAll()
        {
            List<ListCustomerResponse> customers = _customerService.GetAll();
            customerDataGridView.DataSource = customers;
        }

        private void customerDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (customerDataGridView.SelectedRows.Count <= 0) return;
            var firstlySelectedRow = customerDataGridView.SelectedRows[0];


            UpdateFirstNameTb.Text = firstlySelectedRow.Cells["FirstName"].Value.ToString();
            UpdateLastNameTb.Text = firstlySelectedRow.Cells["LastName"].Value.ToString();
            UpdateIdentityNumberTb.Text = firstlySelectedRow.Cells["IdentityNumber"].Value.ToString();
            UpdateBirthDatePicker.Text = firstlySelectedRow.Cells["BirthDate"].Value.ToString();
            UpdateCompanyNameTb.Text = firstlySelectedRow.Cells["CompanyName"].Value.ToString();
            UpdateCountryTb.Text = firstlySelectedRow.Cells["Country"].Value.ToString();
            UpdatePhoneTb.Text = firstlySelectedRow.Cells["Phone"].Value.ToString();
            UpdateCustomerIdTb.Text = firstlySelectedRow.Cells["CustomerID"].Value.ToString();

        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            GetAll();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            CreateCustomerRequest createCustomerRequest = new CreateCustomerRequest()
            {
                CustomerID = AddCustomerIdTb.Text,
                CompanyName = AddCompanyNameTb.Text,
                Country = AddCountryTb.Text,
                Phone = AddPhoneTb.Text,
                FirstName = AddFirstNameTb.Text,
                LastName = AddLastNameTb.Text,
                IdentityNumber = AddIdentityNumberTb.Text,
                BirthDate = AddBirthDatePicker.Value

            };

            _customerService.Add(createCustomerRequest);
            MessageBox.Show("Müşteri Eklendi", "Başarılı");
            GetAll();
            clearAddCustomerForm();

        }

        private void clearAddCustomerForm()
        {
            AddCustomerIdTb.Text = String.Empty;
            AddCompanyNameTb.Text =String.Empty;
            AddCountryTb.Text= String.Empty;
            AddPhoneTb.Text = String.Empty;
            AddFirstNameTb.Text = String.Empty;
            AddLastNameTb.Text = String.Empty;
            AddIdentityNumberTb.Text = String.Empty;
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (customerDataGridView.SelectedRows.Count <= 0) return;
            UpdateCustomerRequest updateCustomerRequest = new UpdateCustomerRequest()
            {
                CustomerID = UpdateCustomerIdTb.Text,
                CompanyName = UpdateCompanyNameTb.Text,
                Country = UpdateCountryTb.Text,
                Phone = UpdatePhoneTb.Text,
                FirstName = UpdateFirstNameTb.Text,
                LastName = UpdateLastNameTb.Text,
                IdentityNumber = UpdateIdentityNumberTb.Text,
                BirthDate = UpdateBirthDatePicker.Value
            };
            _customerService.Update(updateCustomerRequest);
            MessageBox.Show("Müşteri Güncellendi", "Başarılı");
            GetAll();


        }
    }
}
