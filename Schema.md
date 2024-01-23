[dbdiagram.io](https://dbdiagram.io/d)
```
Table Vav_role {
  Popis string
  Vav_role_osoba_Id char [primary key]
}

Table NAVRH_osoba {
  NAVRH_osoba_Id integer [primary key]
  Vav_role_osoba_Id char
  Pohlavi string
  NAVRH_prac_vazba_Id integer
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
}

Ref: Navrh.NAVRH_prac_vazba_Id < NAVRH_prac_vazba.NAVRH_prac_vazba_Id // many-to-one

Ref: NAVRH_prac_vazba.NAVRH_prac_vazba_Id < NAVRH_osoba.NAVRH_prac_vazba_Id

Ref: NAVRH_osoba.Vav_role_osoba_Id < Vav_role.Vav_role_osoba_Id

Table Rozpocet {
  Projekt_rozpocet_Id integer [primary key]
  Projekt_Id integer
  Mena string
  Platnost_od timestamp
}

Table Rozpocet_radek {
  Projekt_rozpocet_radek_Id integer [primary key]
  Projekt_rozpocet_Id integer
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

Table PROJEKT_osoba {
  PROJEKT_osoba_Id integer [primary key]
  Vav_role_osoba_Id char
  Pohlavi string
  PROJEKT_prac_vazba_Id integer
}

Table PROJEKT_prac_vazba {
  PROJEKT_prac_vazba_Id integer [primary key]
  Projekt_Id integer
}

Table Projekt {
  Projekt_Id integer [primary key]
  Navrh_Id integer
  Datum_navrhu timestamp
  Datum_zahajeni timestamp
  Datum_ukonceni timestamp
  Navrhovatel_gender string
  PROJEKT_prac_vazba_Id integer
}

Ref: Projekt.PROJEKT_prac_vazba_Id < PROJEKT_prac_vazba.PROJEKT_prac_vazba_Id // many-to-one

Ref: PROJEKT_prac_vazba.PROJEKT_prac_vazba_Id < PROJEKT_osoba.PROJEKT_prac_vazba_Id

Ref: PROJEKT_osoba.Vav_role_osoba_Id < Vav_role.Vav_role_osoba_Id
Ref: Projekt.Projekt_Id < Rozpocet.Projekt_Id
Ref: Rozpocet_radek.Projekt_rozpocet_Id > Rozpocet.Projekt_rozpocet_Id
Ref: denni_kurz.kod - Rozpocet.Mena
Ref: Projekt.Navrh_Id - Navrh.Navrh_Id
```