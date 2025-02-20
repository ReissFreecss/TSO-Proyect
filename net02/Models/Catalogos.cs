﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net02.Models
{
    public class Catalogos
    {
        public static readonly Dictionary<string, string> Entidades = new Dictionary<string, string>()
        {
            {"AS","AGUASCALIENTES"},
            {"BS","BAJA CALIFORNIA SUR"},
            {"CL","COAHUILA"},
            {"CS","CHIAPAS"},
            {"DF","DISTRITO FEDERAL"},
            {"GT","GUANAJUATO"},
            {"HG","HIDALGO"},
            {"MC","ESTADO DE MÉXICO"},
            {"MS","MORELOS"},
            {"NL","NUEVO LEÓN"},
            {"PL","PUEBLA"},
            {"QR","QUINTANA ROO"},
            {"SL","SINALOA"},
            {"TC","TABASCO"},
            {"TL","TLAXCALA"},
            {"YN","YUCATÁN"},
            {"NE","EXTRANJERO"},
            {"BC","BAJA CALIFORNIA "},
            {"CC","CAMPECHE"},
            {"CM","COLIMA"},
            {"CH","CHIHUAHUA"},
            {"DG","DURANGO"},
            {"GR","GUERRERO"},
            {"JC","JALISCO"},
            {"MN","MICHOACÁN"},
            {"NT","NAYARIT"},
            {"OC","OAXACA"},
            {"QT","QUERÉTARO"},
            {"SP","SAN LUIS POTOSÍ"},
            {"SR","SONORA"},
            {"TS","TAMAULIPAS"},
            {"VZ","VERACRUZ"},
            {"ZS","ZACATECAS"},

        };

        /* Agregar anexos 1 al 4 de RFC con por lo menos un dato (Acomodar string, int)*/

        public static readonly Dictionary<char, string> Anexo1 = new Dictionary<char, string>()
{
    {' ', "00"},
    {'0', "00"},
    {'1', "01"},
    {'2', "02"},
    {'3', "03"},
    {'4', "04"},
    {'5', "05"},
    {'6', "06"},
    {'7', "07"},
    {'8', "08"},
    {'9', "09"},
    {'&', "10"},
    {'A', "11"},
    {'B', "12"},
    {'C', "13"},
    {'D', "14"},
    {'E', "15"},
    {'F', "16"},
    {'G', "17"},
    {'H', "18"},
    {'I', "19"},
    {'J', "21"},
    {'K', "22"},
    {'L', "23"},
    {'M', "24"},
    {'N', "25"},
    {'O', "26"},
    {'P', "27"},
    {'Q', "28"},
    {'R', "29"},
    {'S', "32"},
    {'T', "33"},
    {'U', "34"},
    {'V', "35"},
    {'W', "36"},
    {'X', "37"},
    {'Y', "38"},
    {'Z', "39"},
    {'Ñ', "40"},
};


        public static readonly Dictionary<int, char> Anexo2 = new Dictionary<int, char>()
{
    {0, '1'},
    {1, '2'},
    {2, '3'},
    {3, '4'},
    {4, '5'},
    {5, '6'},
    {6, '7'},
    {7, '8'},
    {8, '9'},
    {9, 'A'},
    {10, 'B'},
    {11, 'C'},
    {12, 'D'},
    {13, 'E'},
    {14, 'F'},
    {15, 'G'},
    {16, 'H'},
    {17, 'I'},
    {18, 'J'},
    {19, 'K'},
    {20, 'L'},
    {21, 'M'},
    {22, 'N'},
    {23, 'P'},
    {24, 'Q'},
    {25, 'R'},
    {26, 'S'},
    {27, 'T'},
    {28, 'U'},
    {29, 'V'},
    {30, 'W'},
    {31, 'X'},
    {32, 'Y'},
    {33, 'Z'},
};


        public static readonly Dictionary<char, int> Anexo3 = new Dictionary<char, int>()
{
    {'0', 00},
    {'1', 01},
    {'2', 02},
    {'3', 03},
    {'4', 04},
    {'5', 05},
    {'6', 06},
    {'7', 07},
    {'8', 08},
    {'9', 09},
    {'A', 10},
    {'B', 11},
    {'C', 12},
    {'D', 13},
    {'E', 14},
    {'F', 15},
    {'G', 16},
    {'H', 17},
    {'I', 18},
    {'J', 19},
    {'K', 20},
    {'L', 21},
    {'M', 22},
    {'N', 23},
    {'&', 24},
    {'O', 25},
    {'P', 26},
    {'Q', 27},
    {'R', 28},
    {'S', 29},
    {'T', 30},
    {'U', 31},
    {'V', 32},
    {'W', 33},
    {'X', 34},
    {'Y', 35},
    {'Z', 36},
    {' ', 37},
    {'Ñ', 38},
};


        public static readonly Dictionary<string, string> Anexo4 = new Dictionary<string, string>()
{
    {"BUEI","BUEX"},
    {"CACA","CACX"},
    {"CAGA","CAGX"},
    {"CAKA","CAKX"},
    {"COGE","COGX"},
    {"COJE","COJX"},
    {"COJO","COJX"},
    {"FETO","FETX"},
    {"JOTO","JOTX"},
    {"KACO","KACX"},
    {"KAGO","KAGX"},
    {"KOJO","KOJX"},
    {"KULO","KULX"},
    {"MAMO","MAMX"},
    {"MEAS","MEAX"},
    {"MION","MIOX"},
    {"MULA","MULX"},
    {"PEDO","PEDX"},
    {"PUTA","PUTX"},
    {"QULO","QULX"},
    {"RUIN","RUIX"},
    {"BUEY","BUEX"},
    {"CACO","CACX"},
    {"CAGO","CAGX"},
    {"CAKO","CAKX"},
    {"COJA","COJX"},
    {"COJI","COJX"},
    {"CULO","CULX"},
    {"GUEY","GUEX"},
    {"KACA","KACX"},
    {"KAGA","KAGX"},
    {"KOGE","KOGX"},
    {"KAKA","KAKX"},
    {"MAME","MAMX"},
    {"MEAR","MEAX"},
    {"MEON","MEOX"},
    {"MOCO","MOCX"},
    {"PEDA","PEDX"},
    {"PENE","PENX"},
    {"PUTO","PUTX"},
    {"RATA","RATX"},
};

    }
}
