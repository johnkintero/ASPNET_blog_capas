using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using blogApp.Entidades;

namespace blogApp.DAL
{
    public class Blog
    {
        BlogEntities db = new BlogEntities();
        public List<post> GetPost()
        {
            using (BlogEntities db = new BlogEntities())
            {
                return db.posts.ToList();
            }
        }

        public post getPostbyID(int _id)
        {
            post fundPost = new post();
            try
            {
                fundPost = db.posts.Find(_id);
                return fundPost;
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
                var post = new post { C_id = postMod.C_id };
                db.posts.Attach(post);
                post.titulo = postMod.titulo;
                post.urlimagen = postMod.urlimagen;
                post.post1 = postMod.post1;
                post.autor = postMod.autor;
                db.SaveChanges();
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
                var post = new post { C_id = _id };
                db.posts.Attach(post);
                db.posts.Remove(post);
                db.SaveChanges();
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
                using (BlogEntities db = new BlogEntities())
                {
                    db.posts.Add(newPost);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
