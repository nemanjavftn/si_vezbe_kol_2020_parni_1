# si_vezbe_kol_2020_parni_1

Тип апликације: Windows– трослојна архитектура
-	Креирати базу података под називом ShopDB и у оквиру ње направити табелу Products са следећим колонама: Id int PK auto increment, Name nvarchar(50) NOT NULL, Description nvarchar(2000) NULL, ExpiryDate DateTime NULL. (2 бодa)
-	Креирати слој који ће вршити конекцију на базу података (Data Layer) и где ће постојати један репозиторијум за комуникацију са креираном табелом у бази података (Products). У оквиру репозиторијума треба да постоје методе: InsertProduct (користи се за унос података у табелу Products) и GetAllProducts (за довлачење свих производа из базе података). Што се тиче модела, треба креирати модел-класу под називом Product са приватним пољима Id, Name, Description и ExpiryDate. (5 бодова)
-	Креирати слој у ком ће се налазити логика апликације и где ће у оквиру посебне business класе за рад са Product вертикалом постојати две методе које преко Data слоја врше унос и довлачење производа из репозиторијума. Метода која врши довлачење података треба да врати само производе чији рок трајања није прошао. (5 бодова)
-	На крају, направити .Net Windows Forms апликацију где ће се на почетној форми (текст форме на насловној линији: Proizvodi) вршити унос једног производа у базу података а у доњем делу форме ће се налазити један ListBox који приказује листу производа (формат: <Id>. <Name>). Током отварање форме одмах се приказују производи из базе. На сваки унос новог производа треба refresh-овати листу. (6 бодова)
Напомене: Користити лабеле поред контрола како би форма “имала смисла”. У моделима користити приватна поља и јавна својства (или аутосвојства).
