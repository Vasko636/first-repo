using Business;
using Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BicycleApp
{
    public partial class BicycleForm : Form
    {
        private BicycleBusiness bicycleBusiness = new BicycleBusiness();
        private int editId = 0;
        public BicycleForm()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var item = dataGridView1.SelectedRows[0].Cells;
            var id = int.Parse(item[0].Value.ToString());
            editId = id;
            UpdateTextBoxes(id);
            ToggleSaveUpdate();
            DisableSelect();
        }

        private void BicycleForm_Load(object sender, EventArgs e)
        {
           
        } 
        private void UpdateGrid()
        {
            dataGridView1.DataSource = bicycleBusiness.GetAllBikes();
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void ClearTextBoxes()
        {
             txtModel.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Bike editedBike = GetEditBike();
            bicycleBusiness.UpdateBike(editedBike);
            UpdateGrid();
            ResetSelect();
            ToggleSaveUpdate();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var model = txtModel.Text;
            Bike bike = new Bike();
            bike.Model = model;
            bicycleBusiness.AddBike(bike);
            UpdateGrid();
            ClearTextBoxes();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count>0)
            {
                var item = dataGridView1.SelectedRows[0].Cells;
                var id = int.Parse(item[0].Value.ToString());
                bicycleBusiness.DeleteBike(id);
                UpdateGrid();
                ClearTextBoxes();

            }
        }
        private void UpdateTextBoxes(int id)
        {
            Bike update = bicycleBusiness.GetBikes(id);
            txtModel.Text = update.Model;
        }
        private void ToggleSaveUpdate()
        {
            if (btnUpdate.Visible)
            {
                btnSave.Visible = true;
                btnUpdate.Visible = false;
            }
            else
            {
                btnSave.Visible = false;
                btnUpdate.Visible = true;
            }
        }
        private void DisableSelect()
        {
            dataGridView1.Enabled = false;
        }
        private Bike GetEditBike()
        {
            Bike bike = new Bike();
            bike.Id = editId;
            var model = txtModel.Text;
            bike.Model = model;
            return bike;
        }
        private void ResetSelect()
        {
            dataGridView1.ClearSelection();
            dataGridView1.Enabled = true;

        }

        
        private void BicycleForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
