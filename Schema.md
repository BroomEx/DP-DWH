[dbdiagram.io](https://dbdiagram.io/d)

```
Table Vav_role_osoba {
  Popis string
  Role_osoba_Id char [primary key]
}

Table NAVRH_osoba {
  NAVRH_osoba_Id integer [primary key]
  NAVRH_prac_vazba_Id integer
  Role_osoba_Id char
  Pohlavi string
}

Table NAVRH_prac_vazba {
  NAVRH_prac_vazba_Id integer [primary key]
  Navrh_Id integer
}

Table Navrh {
  Navrh_Id integer [primary key]
  Projekt_Id integer
  Datum_navrhu timestamp
  Datum_zahajeni timestamp
  Datum_ukonceni timestamp
  Navrhovatel_gender string
  NAVRH_prac_vazba_Id integer
  Navrh_stav_id integer
}

Ref: Navrh.NAVRH_prac_vazba_Id < NAVRH_prac_vazba.NAVRH_prac_vazba_Id // many-to-one

Ref: NAVRH_prac_vazba.NAVRH_prac_vazba_Id < NAVRH_osoba.NAVRH_prac_vazba_Id

// Ref: NAVRH_osoba.Role_osoba_Id < Vav_role_osoba.Role_osoba_Id

Table Rozpocet {
  Rozpoc_Id integer [primary key]
  Projekt_Id integer
  Mena string
  Platnost_od timestamp
}

Table Rozpocet_radek {
  Rozpoc_radek_Id integer [primary key]
  Rozpoc_Id integer
  N_Investicni float
  N_Neinvesticni float
  Rok integer
}

Table denni_kurz {
  kod string
  kurz float
  mena string
  mnozstvi integer
  zeme string
}

Table PROJEKT_osoby {
  PROJEKT_osoba_Id integer [primary key]
  Pohlavi string
  NP_prac_Id integer
  Role_osoba_Id char
}

Table PROJEKT_prac_vazba {
  NP_prac_Id integer [primary key]
  Projekt_Id integer
}

Table Projekt {
  Projekt_Id integer [primary key]
  Navrh_Id integer
  Datum_navrhu timestamp
  Datum_zahajeni timestamp
  Datum_ukonceni timestamp
  Gender string
  NP_prac_Id integer
}

Ref: Projekt.NP_prac_Id < PROJEKT_prac_vazba.NP_prac_Id // many-to-one

Ref: PROJEKT_prac_vazba.NP_prac_Id < PROJEKT_osoby.NP_prac_Id

Ref: PROJEKT_osoby.Role_osoba_Id < Vav_role_osoba.Role_osoba_Id
Ref: Projekt.Projekt_Id < Rozpocet.Projekt_Id
Ref: Rozpocet_radek.Rozpoc_Id > Rozpocet.Rozpoc_Id
Ref: denni_kurz.kod - Rozpocet.Mena
//Ref: Projekt.Navrh_Id - Navrh.Navrh_Id

// Ref: "PROJEKT_prac_vazba"."Projekt_Id" < "PROJEKT_prac_vazba"."NP_prac_Id"
```

```
Table Faktura {
  Faktura_Id integer [primary key]
  Datum_vystaveni timestanp
}

Table Platce {
  Platce_Id integer [primary key]
  Jmeno string
  Prijmeni string
  Faktura_Id integer
}

Table Vystavitel {
  Vystavitel_Id integer [primary key]
  Jmeno string
  Prijmeni string
  Faktura_Id integer
}

Table Polozka {
  Polozka_Id integer [primary key]
  Jmeno string
  Hodnota float
  Faktura_Id integer
}

Table Platba {
  Platba_Id integer [primary key]
  Jmeno string
  Prijmeni string
  Castka float
  Faktura_Id integer
}

Table Poznamka {
  Poznamka_Id integer [primary key]
  Text string
  Platba_Id integer
}

Table Platebni_metoda {
  Platebni_metoda_Id integer [primary key]
  Limit integer
  Platba_Id integer
}
Ref: Platba.Platba_Id - Faktura.Faktura_Id
Ref: Platba.Platba_Id - Platebni_metoda.Platba_Id
Ref: Platba.Platba_Id < Poznamka.Platba_Id

Ref: Faktura.Faktura_Id - Platce.Faktura_Id// many-to-one

Ref: Faktura.Faktura_Id < Vystavitel.Faktura_Id

Ref: Faktura.Faktura_Id < Polozka.Faktura_Id
```