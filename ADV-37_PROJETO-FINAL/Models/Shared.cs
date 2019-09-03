using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;

namespace ADV_37_PROJETO_FINAL.Models
{
    /// <summary>
    /// //
    /// </summary>

    struct Shared
    {
        public static string stPathDHTML = Path.GetFullPath(@"relatorios\");

        ///<sumary>
        ///  .....
        ///  </sumary>

        public static void GeraFolhaDeEstilo()
        {
            if (!File.Exists(Shared.stPathDHTML + "estilo.css"))
            {
                using (StreamWriter srite = new StreamWriter(Shared.stPathDHTML + "estilo.css"))
                {
                    srite.WriteLine("@charset{0}", "'utf-8'");
                    srite.WriteLine("*{margin:0;padding:0};");
                    srite.WriteLine("#box{width:835px; height:auto; border:4px solid #ededed;}");
                    srite.WriteLine("table{width:830px; border:0; margin:0; padding:0;}");
                    srite.WriteLine("#cabecalho{height:30px; background:#C7D5E3; font:16px Arial, Helvetica, Sans-serif: padding:4px; margin:0;}");
                    srite.WriteLine("table th{width:120px; text-align:left;}");
                    srite.WriteLine("table th.smal{ width:70px;}");
                    srite.WriteLine(".impar{ background:#ededed;}");
                };
            }
        }
    }
}