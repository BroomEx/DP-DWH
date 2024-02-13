[dbdiagram.io](https://dbdiagram.io/d)

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
  Faktura_Id integer
  Jmeno string
  Prijmeni string
  Castka float

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
Ref: Platba.Faktura_Id - Faktura.Faktura_Id
Ref: Platba.Platba_Id - Platebni_metoda.Platba_Id
Ref: Platba.Platba_Id < Poznamka.Platba_Id

Ref: Faktura.Faktura_Id - Platce.Faktura_Id// many-to-one

Ref: Faktura.Faktura_Id < Vystavitel.Faktura_Id

Ref: Faktura.Faktura_Id < Polozka.Faktura_Id
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