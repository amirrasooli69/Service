﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Service
{
    public partial class FormDelete : Form
    {
        public FormDelete()
        {
            InitializeComponent();
        }
        #region Search With Eshterak
        private void Search_Eshterak()
        {
            try
            {
                
                using (var context = new StimulsoftEntities())
                {
                    var find = context.User.Where(current => current.Eshterak.Contains(txtEshterak.Text)).ToList();
                    dgDelete.DataSource = find;
                    //-----------------
                    dgDelete.Columns[0].HeaderText = "اشتراک";
                    dgDelete.Columns[1].HeaderText = "نام";
                    //dgDelete.Columns[2].Visible = false;
                    dgDelete.Columns[2].HeaderText = " تاریخ";
                    //dgDelete.Columns[3].Visible = false;
                    dgDelete.Columns[3].HeaderText = "شماره تماس";
                    //dgDelete.Columns[4].Visible = false;
                    dgDelete.Columns[4].HeaderText = "ایمیل";
                    // dgDelete.Columns[5].Visible = false;
                    dgDelete.Columns[5].HeaderText = "تاریخ تولد";
                    //dgDelete.Columns[6].Visible = false;
                    dgDelete.Columns[6].HeaderText = "آدرس";
                    dgDelete.Columns[7].HeaderText = "کد پستی";
                    dgDelete.Columns[8].Visible = false;
                    dgDelete.Columns[8].HeaderText = "شماره ";
                    //-----------------
                    dgDelete.Show();
                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        #endregion

        #region Search Service
        private void Search_Service()
        {
            try
            {
                using (var context = new StimulsoftEntities())
                {
                    var find = context.Service.Where(current => current.Eshterak.Contains(txtEshterak.Text)).ToList();
                    dgDelete.DataSource = find;
                    //--------------------

                    dgDelete.Columns[0].Name = "Eshterak";
                    dgDelete.Columns[0].DataPropertyName = "Eshterak";
                    dgDelete.Columns[0].HeaderText = "اشتراک";
                    //------
                    dgDelete.Columns[1].Name = "Name";
                    dgDelete.Columns[1].DataPropertyName = "Name";
                    dgDelete.Columns[1].HeaderText = "نام";
                    //------
                    dgDelete.Columns[2].Name = "DateService";
                    dgDelete.Columns[2].DataPropertyName = "DateService";
                    dgDelete.Columns[2].HeaderText = "تاریخ سرویس";
                    dgDelete.Columns[2].DefaultCellStyle.Format = "0000/00/00";
                    //-------
                    dgDelete.Columns[3].Name = "Mobile";
                    dgDelete.Columns[3].DataPropertyName = "Mobile";
                    dgDelete.Columns[3].HeaderText = "شماره تماس";
                    //-------
                    dgDelete.Columns[4].Name = "Bestankar";
                    dgDelete.Columns[4].DataPropertyName = "Bestankar";
                    dgDelete.Columns[4].HeaderText = "بیعانه";
                    //-------
                    dgDelete.Columns[5].Name = "Pardakhti";
                    dgDelete.Columns[5].DataPropertyName = "Pardakhti";
                    dgDelete.Columns[5].HeaderText = "پرداختی";
                    //------
                    dgDelete.Columns[6].Name = "Takhfif";
                    dgDelete.Columns[6].DataPropertyName = "Takhfif";
                    dgDelete.Columns[6].HeaderText = "تخفیف ";
                    //-------
                    dgDelete.Columns[7].Name = "ValueAdded";
                    dgDelete.Columns[7].DataPropertyName = "ValueAdded";
                    dgDelete.Columns[7].HeaderText = "ارزش افزوده ";
                    //-------

                    dgDelete.Columns[8].Name = "SumServices";
                    dgDelete.Columns[8].DataPropertyName = "SumServices";
                    dgDelete.Columns[8].HeaderText = " مبلغ کل";
                    ///------
                    dgDelete.Columns[9].Name = "CodeRahgiri";
                    dgDelete.Columns[9].DataPropertyName = "CodeRahgiri";
                    dgDelete.Columns[9].HeaderText = "کد رهگیری";
                    ///------
                    dgDelete.Columns[10].Name = "NumberService";
                    dgDelete.Columns[10].DataPropertyName = "NumberService";
                    dgDelete.Columns[10].HeaderText = "تعداد";
                    ///------
                    dgDelete.Columns[11].Name = "ReadyDate";
                    dgDelete.Columns[11].DataPropertyName = "ReadyDate";
                    dgDelete.Columns[11].HeaderText = "تاریخ آماده";
                    dgDelete.Columns[11].DefaultCellStyle.Format = "0000/00/00";
                    ///------
                    dgDelete.Columns[12].Name = "SendReadySms";
                    dgDelete.Columns[12].DataPropertyName = "SendReadySms";
                    dgDelete.Columns[12].HeaderText = "تعداد پیامک آماده";
                    ///------
                    dgDelete.Columns[13].Name = "Description";
                    dgDelete.Columns[13].DataPropertyName = "Description";
                    dgDelete.Columns[13].HeaderText = "توضیحات ";
                    ///------
                    dgDelete.Columns[14].Name = "IdService";
                    dgDelete.Columns[14].DataPropertyName = "IdService";
                    dgDelete.Columns[14].HeaderText = "شماره ";
                    dgDelete.Columns[14].Visible = false;
                    //-------
                    dgDelete.Columns[15].Name = "OrderState";
                    dgDelete.Columns[15].DataPropertyName = "OrderState";
                    dgDelete.Columns[15].HeaderText = "نحوه سفارش";
                    //-------
                    dgDelete.Columns[16].Name = "TabelState";
                    dgDelete.Columns[16].DataPropertyName = "TabelState";
                    dgDelete.Columns[16].HeaderText = "میز";
                    //-------
                    dgDelete.Columns[17].Name = "PayeState";
                    dgDelete.Columns[17].DataPropertyName = "PayeState";
                    dgDelete.Columns[17].HeaderText = " پرداخت";

                    dgDelete.Show();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }


        #endregion
        public void Refresh_dgUser()
        {
            try
            {
                using (var context = new StimulsoftEntities())
                {
                    dgDelete.DataSource = context.User.Where(current => current.Eshterak != null).ToList();
                    dgDelete.Columns[0].HeaderText = "اشتراک";
                    dgDelete.Columns[1].HeaderText = "نام";
                    //dgDelete.Columns[2].Visible = false;
                    dgDelete.Columns[2].HeaderText = " تاریخ";
                    //dgDelete.Columns[3].Visible = false;
                    dgDelete.Columns[3].HeaderText = "شماره تماس";
                    //dgDelete.Columns[4].Visible = false;
                    dgDelete.Columns[4].HeaderText = "ایمیل";
                    // dgDelete.Columns[5].Visible = false;
                    dgDelete.Columns[5].HeaderText = "تاریخ تولد";
                    //dgDelete.Columns[6].Visible = false;
                    dgDelete.Columns[6].HeaderText = "آدرس";
                    dgDelete.Columns[7].HeaderText = "کد پستی";
                    dgDelete.Columns[8].Visible = false;
                    dgDelete.Columns[8].HeaderText = "شماره ";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

         }
        public void Refresh_dgService()
        {
            using (var context = new StimulsoftEntities())
            {
                dgDelete.DataSource = context.Service.Where(current => current.Eshterak != null).ToList();
                dgDelete.DataSource = context.Service.Where(current => current.Eshterak != null).ToList();
                dgDelete.Columns[0].HeaderText = "اشتراک";
                dgDelete.Columns[1].HeaderText = "نام";
                dgDelete.Columns[2].HeaderText = "تاریخ سرویس";
                dgDelete.Columns[2].DefaultCellStyle.Format = "0000/00/00";

                dgDelete.Columns[3].HeaderText = "شماره تماس";
                dgDelete.Columns[4].HeaderText = "بیعانه";
                dgDelete.Columns[5].HeaderText = "پرداختی";
                dgDelete.Columns[6].HeaderText = "تخفیف ";
                dgDelete.Columns[7].HeaderText = "ارزش افزوده";
                //dgDelete.Columns[8].Visible = false;
                dgDelete.Columns[8].HeaderText = "مبلغ";
                dgDelete.Columns[9].HeaderText = "کد رهگیری";
                dgDelete.Columns[10].HeaderText = "تعداد";
                dgDelete.Columns[11].HeaderText = "تاریخ آماده";
                dgDelete.Columns[11].DefaultCellStyle.Format = "0000/00/00";

                dgDelete.Columns[12].HeaderText = "تعداد پیامک آماده";
                dgDelete.Columns[13].HeaderText = "توضیحات ";
                dgDelete.Columns[14].HeaderText = "شماره ";
                dgDelete.Columns[14].Visible = false;
                dgDelete.Columns[15].HeaderText = " سفارش";
                dgDelete.Columns[16].HeaderText = " میز";
                dgDelete.Columns[16].Visible = false;
                dgDelete.Columns[17].HeaderText = " پرداخت";
                //dgDelete.Columns[17].Visible = false;
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (lbldel.Text == "1")
            {
                try
                {
                    lblError.Text = "";
                    try
                    {
                        using (var context = new StimulsoftEntities())
                        {
                            var delete = context.User.Where(current => current.Eshterak==txtEshterak.Text).ToList();
                            if (delete.Count == 0)
                            {
                                var result = MessageBox.Show("شماره اشتراک مورد نظر پیدا نشد،آیا همه موارد را میخواهید؟", "شماره اشتراک", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                if (result == DialogResult.Yes)
                                {
                                    dgDelete.DataSource = context.User.ToList();
                                    Refresh_dgUser();
                                }
                                else
                                {
                                    txtEshterak.Focus();
                                }
                            }
                            if (delete.Count == 1)
                            {
                                User del = context.User.Where(current => current.Eshterak == txtEshterak.Text).FirstOrDefault();
                                context.User.Remove(del);
                                context.SaveChanges();
                                lblError.ForeColor = Color.Green;
                                lblError.Text = " اشتراک با موفقیت حذف شد";
                                context.Dispose();
                                Refresh_dgUser();

                                 txtEshterak.Text = "";
                                 txtEshterak.Focus();
                            }
                            if (delete.Count > 1)
                            {
                                dgDelete.DataSource = delete.ToList();
                            }

                        }
                    }
                    catch (Exception)
                    {
                        lblError.ForeColor = Color.Red;
                        lblError.Text = "عملیات حذف با مشکل مواجه شد";
                        txtEshterak.Focus();
                    }


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            //-----------------------
            //-----------------------
            if (lbldel.Text == "2")
            {
                try
                {
                  lblError.Text = "";
                        using (var context = new StimulsoftEntities())
                        {
                        string id = dgDelete.CurrentRow.Cells[14].Value.ToString();
                        var delete = context.Service.Where(current => current.IdService.ToString()==id).ToList();
                            if (delete.Count == 0)
                            {
                                var result = MessageBox.Show("شماره سرویس مورد نظر پیدا نشد،آیا همه موارد را میخواهید؟", "شماره سرویس", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                if (result == DialogResult.Yes)
                                {
                                    dgDelete.DataSource = context.Service.ToList();
                                    Refresh_dgService();
                                }
                                else
                                {
                                    txtEshterak.Focus();
                                }
                            }
                            if (delete.Count == 1)
                            {
                                var del = context.Service.Where(current => current.IdService.ToString() == id).FirstOrDefault();
                                context.Service.Remove(del);
                                context.SaveChanges();
                                lblError.ForeColor = Color.Green;
                                lblError.Text = " سرویس با موفقیت حذف شد";
                                Refresh_dgService();
                                context.Dispose();
                                

                                 txtEshterak.Text = "";
                                 txtEshterak.Focus();
                            }
                            if (delete.Count > 1)
                            {
                                dgDelete.DataSource = delete.ToList();
                            }

                        }
  

                }
                catch (Exception)
                {
                    lblError.ForeColor = Color.Red;
                    lblError.Text = "عملیات حذف با مشکل مواجه شد";
                    txtEshterak.Focus();
                }

            }
            
        }

        private void FormDelete_Load(object sender, EventArgs e)
        {
            StimulsoftEntities context = new StimulsoftEntities();

            if (lbldel.Text == "2")
            {
                //lblEshterak.Text = "شماره سرویس";
                Refresh_dgService();
                return;
            }
            if (lbldel.Text == "1")
            {
                lblEshterak.Text = "شماره اشتراک";
                Refresh_dgUser();
                //-----
                
                var select = context.User.ToList();
                string[] eshterak = new string[select.Count];
                for (int i = 0; i < select.Count; i++)
                {
                    eshterak[i] = select[i].Eshterak.ToString();
                }
                txtEshterak.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection suggest = new AutoCompleteStringCollection();
                txtEshterak.AutoCompleteCustomSource = suggest;
                suggest.AddRange(eshterak);
            }
        }

        private void txtEshterak_TextChanged(object sender, EventArgs e)
        {
            
            try
            {

                FormMain1 frmmain = new FormMain1();
                if (lbldel.Text == "1")
                {
                    if (txtEshterak.Text == "")
                    {
                        Refresh_dgUser();
                        return;
                    }
                    else
                    {
                        Search_Eshterak();
                        return;
                    }

                }

                if (lbldel.Text == "2")
                {
                    if(txtEshterak.Text=="")
                    {
                        Refresh_dgService();
                        return;
                    }
                    else
                    {
                        Search_Service();
                    }
                }
                    
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void dgDelete_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblError.Text = "";
            try
            {
                if (lbldel.Text == "1")
                {
                    if (dgDelete.CurrentRow.Cells[0].Selected || dgDelete.CurrentRow.Cells[1].Selected || dgDelete.CurrentRow.Cells[2].Selected || dgDelete.CurrentRow.Cells[3].Selected)
                    {
                        txtEshterak.Text = dgDelete.CurrentRow.Cells[0].Value.ToString();
                    }
                    return;
                }
                if (lbldel.Text == "2")
                {
                    if (dgDelete.CurrentRow.Cells[0].Selected || dgDelete.CurrentRow.Cells[1].Selected || dgDelete.CurrentRow.Cells[2].Selected || dgDelete.CurrentRow.Cells[3].Selected)
                    {
                        txtEshterak.Text = dgDelete.CurrentRow.Cells[0].Value.ToString();
                    }
                }
            }
            catch (Exception)
            {
                lblError.ForeColor = Color.Red;
                lblError.Text = "مقداری وجود ندارد";
            }
        }
    }
}
