using System;
using System.Text.RegularExpressions;

namespace Sh0utbox
{
    public class TextUtils
    {
        public static string CheckforEmoticons(string txt)
        {
            string newtxt = txt;

            //Kappa
            newtxt =
                newtxt.Replace(
                    "<img src='http://www.nulled.io/public/style_emoticons/default/kappa.png' class='bbc_emoticon' alt='Kappa'/>",
                    "<img src='http://i.imgur.com/Xwp3fim.png' class='bbc_emoticon' alt='Kappa'/>");
            
            //kappahd
            newtxt =
                newtxt.Replace(
                    "<img src='http://www.nulled.io/public/style_emoticons/default/kappahd.png' class='bbc_emoticon' alt='kappahd'/>",
                    "<img src='http://i.imgur.com/CJw3fJ0.png' class='bbc_emoticon' alt='kappahd'/>");

            //minikappa
            newtxt = newtxt.Replace(
                    "<img src='http://www.nulled.io/public/style_emoticons/default/minikappa.png' class='bbc_emoticon' alt='minikappa'/>",
                    "<img src='http://i.imgur.com/9AAkzRg.png' class='bbc_emoticon' alt='minikappa'/>");

            //keepo
            newtxt = newtxt.Replace(
                    "<img src='http://www.nulled.io/public/style_emoticons/default/keepo.png' class='bbc_emoticon' alt='keepo'/>",
                    "<img src='http://i.imgur.com/yPcGqJ1.png' class='bbc_emoticon' alt='Kappa'/>");

            //doge
            newtxt = newtxt.Replace(
                    "<img src='http://www.nulled.io/public/style_emoticons/default/doge.png' class='bbc_emoticon' alt='doge'/>",
                    "<img src='http://i.imgur.com/C6puMKF.png' class='bbc_emoticon' alt='doge'/>");

            //FrankerZ
            newtxt = newtxt.Replace(
                    "<img src='http://www.nulled.io/public/style_emoticons/default/frankerz.png' class='bbc_emoticon' alt='FrankerZ'/>",
                    "<img src='http://i.imgur.com/jTKkDBD.png' class='bbc_emoticon' alt='FrankerZ'/>");

            //:wub:
            newtxt = newtxt.Replace(
                    "<img src='http://www.nulled.io/public/style_emoticons/default/wub.png' class='bbc_emoticon' alt=':wub:'/>",
                    "<img src='http://i.imgur.com/tyG2FcU.png' class='bbc_emoticon' alt=':wub:'/>");

            //:ph34r:
            newtxt = newtxt.Replace(
                    "<img src='http://www.nulled.io/public/style_emoticons/default/ph34r.png' class='bbc_emoticon' alt=':ph34r:'/>",
                    "<img src='http://i.imgur.com/jD6oaTl.png' class='bbc_emoticon' alt=':ph34r:'/>");

            //:)
            newtxt =
                newtxt.Replace(
                    "<img src='http://www.nulled.io/public/style_emoticons/default/smile.png' class='bbc_emoticon' alt=':)'/>",
                    "<img src='http://i.imgur.com/ICtHnNb.png' class='bbc_emoticon' alt=':)'/>");

            //:(
            newtxt = newtxt.Replace(
                    "<img src='http://www.nulled.io/public/style_emoticons/default/sad.png' class='bbc_emoticon' alt=':('/>",
                    "<img src='http://i.imgur.com/GdksRTq.png' class='bbc_emoticon' alt=':('/>");

            //:D
            newtxt =
                newtxt.Replace(
                    "<img src='http://www.nulled.io/public/style_emoticons/default/biggrin.png' class='bbc_emoticon' alt=':D'/>",
                    "<img src='http://i.imgur.com/AAqCD4Z.png' class='bbc_emoticon' alt=':D'/>");

            //:P
            newtxt = newtxt.Replace(
                    "<img src='http://www.nulled.io/public/style_emoticons/default/tongue.png' class='bbc_emoticon' alt=':P'/>",
                    "<img src='http://i.imgur.com/d6uyPpq.png' class='bbc_emoticon' alt=':P'/>");

            //:o
            newtxt = newtxt.Replace(
                    "<img src='http://www.nulled.io/public/style_emoticons/default/ohmy.png' class='bbc_emoticon' alt=':o'/>",
                    "<img src='http://i.imgur.com/xvvP2Ic.png' class='bbc_emoticon' alt=':o'/>");

            //B)
            newtxt = newtxt.Replace(
                    "<img src='http://www.nulled.io/public/style_emoticons/default/cool.png' class='bbc_emoticon' alt='B)'/>",
                    "<img src='http://i.imgur.com/lFn6PJj.png' class='bbc_emoticon' alt='B)'/>");

            //;)
            newtxt = newtxt.Replace(
                    "<img src='http://www.nulled.io/public/style_emoticons/default/wink.png' class='bbc_emoticon' alt=';)'/>",
                    "<img src='http://i.imgur.com/qwmbZzU.png' class='bbc_emoticon' alt=';)'/>");

            //:angry:
            newtxt = newtxt.Replace(
                    "<img src='http://www.nulled.io/public/style_emoticons/default/angry.png' class='bbc_emoticon' alt=':angry:'/>",
                    "<img src='http://i.imgur.com/pFmBYRg.png' class='bbc_emoticon' alt=':angry:'/>");

            //:mellow:
            newtxt = newtxt.Replace(
                    "<img src='http://www.nulled.io/public/style_emoticons/default/mellow.png' class='bbc_emoticon' alt=':mellow:'/>",
                    "<img src='http://i.imgur.com/NAC7zIR.png' class='bbc_emoticon' alt=':mellow:'/>");

            //:huh:
            newtxt = newtxt.Replace(
                    "<img src='http://www.nulled.io/public/style_emoticons/default/huh.png' class='bbc_emoticon' alt=':huh:'/>",
                    "<img src='http://i.imgur.com/yuXT8lk.png' class='bbc_emoticon' alt=':huh:'/>");

            //^_^
            newtxt = newtxt.Replace(
                    "<img src='http://www.nulled.io/public/style_emoticons/default/happy.png' class='bbc_emoticon' alt='^_^'/>",
                    "<img src='http://i.imgur.com/eFpVHSc.png' class='bbc_emoticon' alt='^_^'/>");

            //:rolleyes:
            newtxt = newtxt.Replace(
                    "<img src='http://www.nulled.io/public/style_emoticons/default/rolleyes.gif' class='bbc_emoticon' alt=':rolleyes:'/>",
                    "<img src='http://i.imgur.com/AKDC41B.gif' class='bbc_emoticon' alt=':rolleyes:'/>");

            //-_-
            newtxt = newtxt.Replace(
                    "<img src='http://www.nulled.io/public/style_emoticons/default/sleep.png' class='bbc_emoticon' alt='-_-'/>",
                    "<img src='http://i.imgur.com/F2IhyFh.png' class='bbc_emoticon' alt='-_-'/>");

            //<_<
            newtxt = newtxt.Replace(
                    "<img src='http://www.nulled.io/public/style_emoticons/default/dry.png' class='bbc_emoticon' alt='&lt;_&lt;'/>",
                    "<img src='http://i.imgur.com/qZMKHh0.png' class='bbc_emoticon' alt='<_<'/>");

            //:unsure:
            newtxt = newtxt.Replace(
                    "<img src='http://www.nulled.io/public/style_emoticons/default/unsure.png' class='bbc_emoticon' alt=':unsure:'/>",
                    "<img src='http://i.imgur.com/wGubZ0Y.png' class='bbc_emoticon' alt=':unsure:'/>");

            //:wacko:
            newtxt = newtxt.Replace(
                    "<img src='http://www.nulled.io/public/style_emoticons/default/wacko.png' class='bbc_emoticon' alt=':wacko:'/>",
                    "<img src='http://i.imgur.com/2JaFw7I.png' class='bbc_emoticon' alt=':wacko:'/>");

            //:blink:
            newtxt = newtxt.Replace(
                    "<img src='http://www.nulled.io/public/style_emoticons/default/blink.png' class='bbc_emoticon' alt=':blink:'/>",
                    "<img src='http://i.imgur.com/BshgBCe.png' class='bbc_emoticon' alt=':blink:'/>");

            //:jodus:
            newtxt = newtxt.Replace(
                    "<img src='http://www.nulled.io/public/style_emoticons/default/jodus.png' class='bbc_emoticon' alt=':jodus:'/>",
                    "<img src='http://i.imgur.com/nBGA51X.png' class='bbc_emoticon' alt=':jodus:'/>");

            //:joduscry:
            newtxt = newtxt.Replace(
                    "<img src='http://www.nulled.io/public/style_emoticons/default/josucry.png' class='bbc_emoticon' alt=':joduscry:'/>",
                    "<img src='http://i.imgur.com/6MgBBGa.png' class='bbc_emoticon' alt=':joduscry:'/>");

            return newtxt;
        }

        public static string MakeLink(string txt)
        {
            if (txt.Contains("A new topic called <strong><a href='"))
                return txt;

            Regex regx = new Regex("</span></span></a> http://([\\w+?\\.\\w+])+([a-zA-Z0-9\\~\\!\\@\\#\\$\\%\\^\\&amp;\\*\\(\\)_\\-\\=\\+\\\\\\/\\?\\.\\:\\;\\'\\,]*)?", RegexOptions.IgnoreCase);
            MatchCollection mactches = regx.Matches(txt);
            foreach (Match match in mactches)
            {
                if (!match.Value.Contains("nulled.io/public/style_emoticons/"))
                {
                    Console.WriteLine("MATCH: " + match.Value);
                    txt = txt.Replace(match.Value, "</span></span></a> <a href='" + match.Value.Remove(0, 19) + "'>" + match.Value.Remove(0, 19) + "</a>");
                    Console.WriteLine("FIXED: " + txt);
                }
            }
            
            return txt;
        }
    }
}
