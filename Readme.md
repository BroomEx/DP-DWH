# DP-DWH Notes
## Služba
1. ~~Definice služby~~
2. ~~čel~~
3. ~~Cíle~~
4. ~~Proces zavádění~~
   1. ~~Zakládací listina - základní parametry~~
      1. Účel
      2. Cíl
      3. KPI
      4. Vize
      5. Owner
   2. Procesy
      1. Uživatel
         1. Žádost o nový report
         2. Nefunkční služba
      2. Provozovatel
         1. Nefunkční služba
         2. Sběr požadavků na nové reporty
            1. Formulář
            2. Aktivní nabízení
   3. Kooperace, zainteresované třetí strany
   4. Zdroje - co je potřeba k zavedení
   5. Monitoring - hlídní funkčnosti služby
      1. Azure + Zabbix
      2. Uživatel
   6. Již implementované reporty
   7. Implementace usecase
      1. Nový požadavek
      2. Konzultace s DWH týmem
      3. Příprava dat
         1. Přidání do ETL
         2. Transformace do datové hvězdy
         3. Úprava přístupových práv k datům
      4. Reportu
         1. Vytvoření
            1. Uživatel sám
            2. Tvorba DWH týmem
         2. Zveřejnění
            1. Nastavení přístupových práv k reportu



## DWH?
### new list
1. Jmenovat lidi - myšleno pana Švaříčka atp.
1. Proces nahlášení nefunkčního skladu, co se děje pak?
1. nový usecase - zapojení třetí strany, je nutné a nebo správce zvládne ETL sám?
1. citace zakládací listiny - asi neveřejný dokument?
1. kooperace a třetí strany -  je zde někdo další krom firmy, co to původně vystavěla?
1. Monitoring - Azure hl9d8 aktivně? Applicatrion Insights? něco dalšího?
1. Zabbix - předpokládám on premise servery?
1. Oracle DB u studoven - kde se berou data?
1. Studovny a RECETOX
   - punková implementace, jak to je?
   - Lze ukázat veřejně?
   - není divné, že i já mám přístup do RECETOXu a Age friendly university? Nebo jsem dostal v rámci DP přístup?

### ????
1. Proč se zvolil DWH
2. DWH
   1. Účel a cíle - je to takhle možné?
   2. DWH tým, bližší popis
      1. Kým je tvořen?
      2. Je dedikován je na údržbu DWH?
3. STAGE server
   1.  Jedná se o file nebo DB server?
   2.  Mažou se data?
4. Usecasy
   1. Kdo je za ně zodpovědnný? Spadá to vše pod ownera?
   2. Aktivní sběr požadavků, děje se?
5. Zakladácí listina - je prázdná, je možné dodat vyplněnou?
6. Implementace usecase
   1. Existuje nějaký ukázkový na kterém lze proces popsat a demonstrovat?
   

## Data model
- Rozpoc_Radek
   - ROZP_TYP
- Rozpoc
   - Smlouva - string a nebo je to reference na t5eba soubor?
   - Mena - ciselnik? Enum? string?
   - Bez_rozpoctu - význam? zatím to chápu jako bool
   - Zmenil - Id usera a nebo proste jmeno?
   - Zmeneno - timestamp?
   - FIN_RMU - Vůbec nevím, co je
- Riv_druh_vysledku
   - Co znamena cela tabulka?
   - riv?
- Proj_Sdg
   - Co znamen8 cela tabulka?
   - Uroven - vyznam, typ
   - Sdg_cislo - vynam, typ
- INVESTOR_TYP
   - Nemá id?
- Np_prac_osoba
   - Akademik - string neba další entita?
   - oscis - vyznam?

   ## TODO
   1. Přepsat procesy dle dedrleho
   1. zminit jiru
   1. zminit chybejici proces vyhodnoceni
      1. chybi, ale kpi tak, jak jsou nastaveny nejsou slozity
      1. navhrnout sledovani vyuziti usecasu
   1. dle springerove centralizovana globální high-touch sluzba
      1. potvrzuje heterogenitu
      1. vlastník je v kategorii manager/product owner
## ISEP usecase
- nezvládá kapacitní plánování do budoucna
   - predikce úvazků na projekty, na základě úvazků

1. incident management
   - ohlašuje se zpátky reportujícímu vyřešení problému?
   - bylo už něco nahlášeno?
1. kolik bylo požadavků na nový usecase? 
1. dostupnost služby - počet incidentů, vypadlo to někdy?
1. aktivní nabízení DWH - proces. jak vypadá?

## Dashboard

1. Personal
   - Hlavní KPI
      - Poměr žen a mužů celkově
      - Poměr žen a můžu v roli řešitele
   - Doplnky
      - Vývoj poměrového zastoupení mužů a žen v posledních pětri letech
      - Vývoj poměru žen v roli řešitele v posledních pěti letech
      - u obojího poměrová změna za sledované období
1. Projekty
   - Hlavní KPI
      - Poměr projektů, které přešli z draftu k realizaci v závislosti na genderu řešitele
      - Relativní rozdíly ve velikostech rozpočtu projektů v závislosti na genederu řešitele
   - Doplňky
      - Trend poměru rozpočtu v závislosti na genderu 



## LINKS
- [DWH web](https://it.muni.cz/sluzby/datovy-sklad-na-mu)
- [DWH reporty](https://it.muni.cz/sluzby/datovy-sklad-na-mu/reportovaci-portal-mu)
- [ProcesZ](https://ucnmuni-my.sharepoint.com/:w:/g/personal/215559_muni_cz/EXu35BtgFOFLlQ5oFOOJZBcBbbXDs9CjSEvT64PxbS90CA?email=527565%40muni.cz&e=4%3AxU94gu&fromShare=true&at=9)

