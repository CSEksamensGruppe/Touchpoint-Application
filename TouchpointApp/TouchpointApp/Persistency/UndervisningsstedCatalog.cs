﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchpointApp.Command;
using TouchpointApp.Model;


public class UndervisningsstedCatalog
    {
        #region Instance Fields
    private List<Undervisningssted> __usl;
    private static UndervisningsstedCatalog _UndervisningsstedCatalog;
        #endregion


    public static UndervisningsstedCatalog Instance()
    {
        if(_UndervisningsstedCatalog == null)
        {
            _UndervisningsstedCatalog = new UndervisningsstedCatalog();

        }
        return _UndervisningsstedCatalog;
    }
        #region Constructor
        public UndervisningsstedCatalog()
        {
            
            __usl = new List<Undervisningssted>();
        }
    #endregion
    public List<Undervisningssted> Getlist
    {
        get { return __usl; }
        set { __usl = value; }
    }

    public List<Undervisningssted> All
    { get; set; }


    #region Metoder

    public void OpretUndervisningssted(string lokale, string adresse)
        {
            Undervisningssted us1 = new Undervisningssted("", "");


            { 
                __usl.Add(us1);
            }
            
        }

    #endregion
    public void Create()
    {

    }

    public void Read()
    {

    }

    public void Update()
    {

    }

}


