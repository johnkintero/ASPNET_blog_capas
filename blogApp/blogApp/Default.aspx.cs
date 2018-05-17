using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using blogApp.BLL;
using blogApp.Entidades;


public partial class _Default : System.Web.UI.Page
{
    blogBLL blogNegocio = new blogBLL();
    protected void Page_Load(object sender, EventArgs e)
    {
        
       
        if (!IsPostBack)
        {
            try
            {
                TraerDatos();
            }
            catch (Exception ex)
            {
                lblerror.Text = ex.Message;
            }
           
        }

    }

    protected void Btnsave_Click(object sender, EventArgs e)
    {
        post newPost = new post
        {
            titulo = txttitulo.Text,
            post1 = txtpost.Text,
            urlimagen = txtimg.Text,
            autor = txtautor.Text,
        };
        try
        {
            blogNegocio.NewPost(newPost);
            Limpiaforma();
            Panel1.Visible = false;
            TraerDatos();
        }
        catch (Exception ex)
        {

            lblerror.Text = ex.Message;
        }
    }

    protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {
        int idsel = Convert.ToInt32(GridView1.DataKeys[e.NewSelectedIndex].Value);
        Panel1.Visible = true;
        Btnupd.Visible = true;
        Btnsave.Visible = false;
        post postEdit = new post();
        postEdit = blogNegocio.GetPostbyID(idsel);
        txttitulo.Text = postEdit.titulo;
        txtpost.Text = postEdit.post1;
        txtimg.Text = postEdit.urlimagen;
        txtautor.Text = postEdit.autor;
        lblID.Text = idsel.ToString();
    }

    protected void Btnupd_Click(object sender, EventArgs e)
    {
        post updPost = new post
        {
            C_id = Convert.ToInt32(lblID.Text),
            titulo = txttitulo.Text,
            post1 = txtpost.Text,
            urlimagen = txtimg.Text,
            autor = txtautor.Text,
        };
        try
        {
            blogNegocio.ActPost(updPost);
            Panel1.Visible = false;
            Limpiaforma();
            TraerDatos();
        }
        catch (Exception ex)
        {

            lblerror.Text = ex.Message;
        }
    }

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        blogNegocio.DelPost(Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value));
        TraerDatos();
    }

    protected void btnnewform_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        Btnsave.Visible = true;
        Btnupd.Visible = false;
    }
    public void Limpiaforma ()
    {
        txtautor.Text = String.Empty;
        txtimg.Text = string.Empty;
        txtpost.Text = string.Empty;
        txttitulo.Text = string.Empty;
    }
    private void TraerDatos()
    {
        try
        {
            GridView1.DataSource = blogNegocio.getpost();
            GridView1.DataBind();
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }
}