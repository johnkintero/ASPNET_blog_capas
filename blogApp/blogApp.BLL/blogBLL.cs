using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using blogApp.DAL;
using blogApp.Entidades;

namespace blogApp.BLL
{
    public class blogBLL
    {
        Blog objBlog = new Blog();
        public List<post> getpost()
        {
            Blog objBlog = new Blog();
            return objBlog.GetPost();
        }
        public post GetPostbyID(int _id)
        {
            try
            {
                return objBlog.getPostbyID(_id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ActPost(post postMod)
        {
            try
            {
                objBlog.ActPost(postMod);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void DelPost(int _id)
        {
            try
            {
                objBlog.DelPost(_id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void NewPost(post newPost)
        {
            try
            {
                objBlog.NewPost(newPost);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
