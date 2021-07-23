using Ex2.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace Ex2.Client.Components.Form
{
    public class SampleFormBase: ComponentBase
    {
        private Contact _contact;
        protected string Error = string.Empty;
        protected bool Success = false;
        public Contact Contact
        {
            get
            {
                return _contact;
            }

            set
            {
                _contact = value;
            }
        }

        public SampleFormBase()
        {
            Contact = new Contact();
            Contact.Couleur = Color.White;
        }

        public void ValideForm()
        {
            //afficher le message à la plce du formulaire
            Success = true;
            Error = string.Empty;
        }

        public void InvalideForm()
        {
            //afficher le message en rouge
            Error = "Veuillez vérifier le formulaire";
        }

        //public void SubmitForm(EditContext ctx)
        //{
        //    if(ctx.Validate())
        //    {
        //        //afficher le message à la plce du formulaire
        //        Success = true;
        //        Error = string.Empty;
        //    }
        //    else
        //    {
        //        //afficher le message en rouge
        //        Error = "Veuillez vérifier le formulaire";
        //    }
        //}
    }
}
