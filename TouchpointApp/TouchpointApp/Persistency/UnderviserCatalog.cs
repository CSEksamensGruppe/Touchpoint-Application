﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchpointApp.Command;
using TouchpointApp.Model;

namespace TouchpointApp.Persistency
{

    public class UnderviserCatalog : WebAPICatalog<Underviser>

    {

    #region Instance Fields

    private List<Underviser> _Ul;

    //singelton instancefield
    private static UnderviserCatalog _UnderviserCatalog;

    #endregion

    #region Constructor

    public UnderviserCatalog() : base ("http://touchpointdbwebservice.azurewebsites.net/api/", "underviser")
    {
        _Ul = new List<Underviser>();
        _Ul.Add(new Underviser("Jonas", "Kildevej 19", "Jonaspedersen@live.dk", "11223344")); //Hard coded objeket. 
        
    }

    #endregion

    //singelton implentering  public method and private constructor
    public static UnderviserCatalog Instance()
    {
        if (_UnderviserCatalog == null)
        {
            _UnderviserCatalog = new UnderviserCatalog();

        }
        return _UnderviserCatalog;
    }

    //propperti for getting our list.
    public List<Underviser> Getlist
    {
        get { return _Ul; }
        set { _Ul = value; }

    }

    public List<Underviser> All { get; set; }


    #region Metoder

    public void OpretUnderviser(string Navn, string Adresse, string email, string tlf)
    {
        Underviser U1 = new Underviser(Navn, Adresse, email, tlf);
        _Ul.Add(U1);
    }

    #endregion

    }
}


