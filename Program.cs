using System;
using System.Collections.Generic;
using System.Text;
using SuperHeroesApp.Models;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var poderVolar = new SuperPoder();
poderVolar.Nombre = "Volar";
poderVolar.Descripcion = "Capacidad para volar";
poderVolar.Nivel = NivelPoder.NivelDos;

var superFuerza = new SuperPoder();
superFuerza.Nombre = "SuperFuerza";
superFuerza.Nivel = NivelPoder.NivelTres;

var superman = new SuperHeroe();
superman.Id = 1;
superman.Nombre = "      Superman     ";
superman.IdentidadSecreta = "Clark";
superman.Ciudad = "Metropolis";
superman.PuedeVolar = true;

List<SuperPoder> poderesSuperman = new List<SuperPoder>();
poderesSuperman.Add(poderVolar);
poderesSuperman.Add(superFuerza);
superman.SuperPoderes = poderesSuperman;
string resultSuperPoderes = superman.UsarSuperPoderes();
Console.WriteLine(resultSuperPoderes); 

var spiderman = new SuperHeroe();
spiderman.Id = 2;
spiderman.Nombre = "Spiderman";
spiderman.IdentidadSecreta = "Peter"; // Corregido el nombre
spiderman.Ciudad = "New York";
spiderman.PuedeVolar = false;

List<SuperPoder> poderesSpiderman = new List<SuperPoder>();
poderesSpiderman.Add(superFuerza);
spiderman.SuperPoderes = poderesSpiderman;

enum NivelPoder
{
    NivelUno,
    NivelDos,
    NivelTres
}
