//---------------------------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated by T4Model template for T4 (https://github.com/linq2db/linq2db).
//    Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//---------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;

using LinqToDB;
using LinqToDB.Mapping;

namespace DataModels
{
	/// <summary>
	/// Database       : emensa
	/// Data Source    : localhost
	/// Server Version : 5.5.5-10.3.11-MariaDB
	/// </summary>
	public partial class EmensaDB : LinqToDB.Data.DataConnection
	{
		public ITable<Benutzer>                  Benutzers                   { get { return this.GetTable<Benutzer>(); } }
		public ITable<Benutzerbefreundetmit>     Benutzerbefreundetmits      { get { return this.GetTable<Benutzerbefreundetmit>(); } }
		public ITable<Bestellungen>              Bestellungens               { get { return this.GetTable<Bestellungen>(); } }
		public ITable<Bilder>                    Bilders                     { get { return this.GetTable<Bilder>(); } }
		public ITable<Deklarationen>             Deklarationens              { get { return this.GetTable<Deklarationen>(); } }
		public ITable<Fachbereiche>              Fachbereiches               { get { return this.GetTable<Fachbereiche>(); } }
		public ITable<Fhangehoerige>             Fhangehoeriges              { get { return this.GetTable<Fhangehoerige>(); } }
		public ITable<Fhangehoerigerfachbereich> Fhangehoerigerfachbereiches { get { return this.GetTable<Fhangehoerigerfachbereich>(); } }
		public ITable<Gaeste>                    Gaestes                     { get { return this.GetTable<Gaeste>(); } }
		public ITable<Kategorien>                Kategoriens                 { get { return this.GetTable<Kategorien>(); } }
		public ITable<Kommentare>                Kommentares                 { get { return this.GetTable<Kommentare>(); } }
		public ITable<Mahlzeiten>                Mahlzeitens                 { get { return this.GetTable<Mahlzeiten>(); } }
		public ITable<Mahlzeitenbestellungen>    Mahlzeitenbestellungens     { get { return this.GetTable<Mahlzeitenbestellungen>(); } }
		public ITable<Mahlzeitenbilder>          Mahlzeitenbilders           { get { return this.GetTable<Mahlzeitenbilder>(); } }
		public ITable<Mahlzeitendeklarationen>   Mahlzeitendeklarationens    { get { return this.GetTable<Mahlzeitendeklarationen>(); } }
		public ITable<Mahlzeitenzutat>           Mahlzeitenzutats            { get { return this.GetTable<Mahlzeitenzutat>(); } }
		public ITable<Mitarbeiter>               Mitarbeiters                { get { return this.GetTable<Mitarbeiter>(); } }
		public ITable<Preise>                    Preises                     { get { return this.GetTable<Preise>(); } }
		public ITable<Studenten>                 Studentens                  { get { return this.GetTable<Studenten>(); } }
		public ITable<VRolle>                    VRolles                     { get { return this.GetTable<VRolle>(); } }
		public ITable<Zutaten>                   Zutatens                    { get { return this.GetTable<Zutaten>(); } }

		public void InitMappingSchema()
		{
		}

		public EmensaDB()
		{
			InitDataContext();
			InitMappingSchema();
		}

		public EmensaDB(string configuration)
			: base(configuration)
		{
			InitDataContext();
			InitMappingSchema();
		}

		partial void InitDataContext();
	}

	[Table("benutzer")]
	public partial class Benutzer
	{
		[Column,        Nullable] public DateTime? Geburtsdatum { get; set; } // date
		[Column,     NotNull    ] public string    Vorname      { get; set; } // varchar(100)
		[Column,     NotNull    ] public string    Nachname     { get; set; } // varchar(50)
		[Column,     NotNull    ] public bool      Aktiv        { get; set; } // tinyint(1)
		[Column,     NotNull    ] public DateTime  Anlegedatum  { get; set; } // date
		[Column,        Nullable] public string    Salt         { get; set; } // varchar(32)
		[Column,        Nullable] public string    Hashk        { get; set; } // varchar(24)
		[Column,     NotNull    ] public string    Nutzername   { get; set; } // varchar(100)
		[PrimaryKey, Identity   ] public uint      Nummer       { get; set; } // int(10) unsigned
		[Column,        Nullable] public DateTime? LetzterLogin { get; set; } // date
		[Column,     NotNull    ] public string    EMail        { get; set; } // varchar(100)

		#region Associations

		/// <summary>
		/// FK_Benutzer1ID_BackReference
		/// </summary>
		[Association(ThisKey="Nummer", OtherKey="Benutzer1ID", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<Benutzerbefreundetmit> Benutzer1Ids { get; set; }

		/// <summary>
		/// FK_Benutzer2ID_BackReference
		/// </summary>
		[Association(ThisKey="Nummer", OtherKey="Benutzer2ID", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<Benutzerbefreundetmit> Benutzer2Ids { get; set; }

		/// <summary>
		/// FK_Benutzer3ID_BackReference
		/// </summary>
		[Association(ThisKey="Nummer", OtherKey="FHAngehoeriger", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<Fhangehoerigerfachbereich> Benutzer3Ids { get; set; }

		/// <summary>
		/// FK_BestellungID_BackReference
		/// </summary>
		[Association(ThisKey="Nummer", OtherKey="BenutzerID", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<Bestellungen> BestellungIds { get; set; }

		/// <summary>
		/// FK_FHAngehoerigeID_BackReference
		/// </summary>
		[Association(ThisKey="Nummer", OtherKey="Nummer", CanBeNull=true, Relationship=Relationship.OneToOne, IsBackReference=true)]
		public Fhangehoerige FHAngehoerigeID { get; set; }

		/// <summary>
		/// FK_GaesteID_BackReference
		/// </summary>
		[Association(ThisKey="Nummer", OtherKey="Nummer", CanBeNull=true, Relationship=Relationship.OneToOne, IsBackReference=true)]
		public Gaeste GaesteID { get; set; }

		#endregion
	}

	[Table("benutzerbefreundetmit")]
	public partial class Benutzerbefreundetmit
	{
		[PrimaryKey(1), NotNull] public uint Benutzer1ID { get; set; } // int(10) unsigned
		[PrimaryKey(2), NotNull] public uint Benutzer2ID { get; set; } // int(10) unsigned

		#region Associations

		/// <summary>
		/// FK_Benutzer1ID
		/// </summary>
		[Association(ThisKey="Benutzer1ID", OtherKey="Nummer", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="FK_Benutzer1ID", BackReferenceName="Benutzer1Ids")]
		public Benutzer Benutzer1 { get; set; }

		/// <summary>
		/// FK_Benutzer2ID
		/// </summary>
		[Association(ThisKey="Benutzer2ID", OtherKey="Nummer", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="FK_Benutzer2ID", BackReferenceName="Benutzer2Ids")]
		public Benutzer Benutzer2 { get; set; }

		#endregion
	}

	[Table("bestellungen")]
	public partial class Bestellungen
	{
		[Column,        Nullable] public DateTime? AbholZeitpunkt   { get; set; } // datetime
		[Column,     NotNull    ] public DateTime  BestellZeitpunkt { get; set; } // datetime
		[PrimaryKey, Identity   ] public uint      Nummer           { get; set; } // int(10) unsigned
		[Column,        Nullable] public decimal?  Endpreis         { get; set; } // decimal(10,0)
		[Column,     NotNull    ] public uint      BenutzerID       { get; set; } // int(10) unsigned

		#region Associations

		/// <summary>
		/// FK_BestellungID
		/// </summary>
		[Association(ThisKey="BenutzerID", OtherKey="Nummer", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="FK_BestellungID", BackReferenceName="BestellungIds")]
		public Benutzer Benutzer { get; set; }

		/// <summary>
		/// FK_Bestellung_BackReference
		/// </summary>
		[Association(ThisKey="Nummer", OtherKey="BestellungID", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<Mahlzeitenbestellungen> Bestellungs { get; set; }

		#endregion
	}

	[Table("bilder")]
	public partial class Bilder
	{
		[PrimaryKey, Identity   ] public uint   ID          { get; set; } // int(10) unsigned
		[Column,     NotNull    ] public string AltText     { get; set; } // varchar(100)
		[Column,        Nullable] public string Titel       { get; set; } // varchar(100)
		[Column,     NotNull    ] public string Binaerdaten { get; set; } // varchar(100)

		#region Associations

		/// <summary>
		/// FK_BildID_BackReference
		/// </summary>
		[Association(ThisKey="ID", OtherKey="BildID", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<Kategorien> BildIds { get; set; }

		/// <summary>
		/// FK_Bild_BackReference
		/// </summary>
		[Association(ThisKey="ID", OtherKey="BildID", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<Mahlzeitenbilder> Bilds { get; set; }

		#endregion
	}

	[Table("deklarationen")]
	public partial class Deklarationen
	{
		[PrimaryKey, NotNull] public string Zeichen      { get; set; } // varchar(2)
		[Column,     NotNull] public string Beschriftung { get; set; } // varchar(64)

		#region Associations

		/// <summary>
		/// FK_DeklarationZeichen_BackReference
		/// </summary>
		[Association(ThisKey="Zeichen", OtherKey="DeklarationZeichen", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<Mahlzeitendeklarationen> DeklarationZeichens { get; set; }

		#endregion
	}

	[Table("fachbereiche")]
	public partial class Fachbereiche
	{
		[PrimaryKey, Identity   ] public uint   ID      { get; set; } // int(10) unsigned
		[Column,     NotNull    ] public string Name    { get; set; } // varchar(100)
		[Column,     NotNull    ] public string Website { get; set; } // varchar(100)
		[Column,        Nullable] public string Adresse { get; set; } // varchar(128)
	}

	[Table("fhangehoerige")]
	public partial class Fhangehoerige
	{
		[PrimaryKey, NotNull] public uint Nummer { get; set; } // int(10) unsigned

		#region Associations

		/// <summary>
		/// FK_FachbereichID_BackReference
		/// </summary>
		[Association(ThisKey="Nummer", OtherKey="Fachbereich", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<Fhangehoerigerfachbereich> FachbereichIds { get; set; }

		/// <summary>
		/// FK_FHAngehoerigeID
		/// </summary>
		[Association(ThisKey="Nummer", OtherKey="Nummer", CanBeNull=false, Relationship=Relationship.OneToOne, KeyName="FK_FHAngehoerigeID", BackReferenceName="FHAngehoerigeID")]
		public Benutzer FHAngehoerigeID { get; set; }

		/// <summary>
		/// FK_MitarbeiterID_BackReference
		/// </summary>
		[Association(ThisKey="Nummer", OtherKey="Nummer", CanBeNull=true, Relationship=Relationship.OneToOne, IsBackReference=true)]
		public Mitarbeiter MitarbeiterID { get; set; }

		/// <summary>
		/// FK_StudentenID_BackReference
		/// </summary>
		[Association(ThisKey="Nummer", OtherKey="Nummer", CanBeNull=true, Relationship=Relationship.OneToOne, IsBackReference=true)]
		public Studenten StudentenID { get; set; }

		#endregion
	}

	[Table("fhangehoerigerfachbereich")]
	public partial class Fhangehoerigerfachbereich
	{
		[PrimaryKey(1), NotNull] public uint FHAngehoeriger { get; set; } // int(10) unsigned
		[PrimaryKey(2), NotNull] public uint Fachbereich    { get; set; } // int(10) unsigned

		#region Associations

		/// <summary>
		/// FK_Benutzer3ID
		/// </summary>
		[Association(ThisKey="FHAngehoeriger", OtherKey="Nummer", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="FK_Benutzer3ID", BackReferenceName="Benutzer3Ids")]
		public Benutzer Benutzer3ID { get; set; }

		/// <summary>
		/// FK_FachbereichID
		/// </summary>
		[Association(ThisKey="Fachbereich", OtherKey="Nummer", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="FK_FachbereichID", BackReferenceName="FachbereichIds")]
		public Fhangehoerige FachbereichID { get; set; }

		#endregion
	}

	[Table("gaeste")]
	public partial class Gaeste
	{
		[PrimaryKey, NotNull    ] public uint      Nummer      { get; set; } // int(10) unsigned
		[Column,     NotNull    ] public string    Grund       { get; set; } // varchar(255)
		[Column,        Nullable] public DateTime? Ablaufdatum { get; set; } // date

		#region Associations

		/// <summary>
		/// FK_GaesteID
		/// </summary>
		[Association(ThisKey="Nummer", OtherKey="Nummer", CanBeNull=false, Relationship=Relationship.OneToOne, KeyName="FK_GaesteID", BackReferenceName="GaesteID")]
		public Benutzer GaesteID { get; set; }

		#endregion
	}

	[Table("kategorien")]
	public partial class Kategorien
	{
		[Column,     NotNull    ] public string Bezeichnung   { get; set; } // varchar(100)
		[PrimaryKey, Identity   ] public uint   ID            { get; set; } // int(10) unsigned
		[Column,        Nullable] public uint?  Oberkategorie { get; set; } // int(10) unsigned
		[Column,        Nullable] public uint?  BildID        { get; set; } // int(10) unsigned
		[Column,     NotNull    ] public uint   PreisID       { get; set; } // int(10) unsigned

		#region Associations

		/// <summary>
		/// FK_BildID
		/// </summary>
		[Association(ThisKey="BildID", OtherKey="ID", CanBeNull=true, Relationship=Relationship.ManyToOne, KeyName="FK_BildID", BackReferenceName="BildIds")]
		public Bilder Bild { get; set; }

		/// <summary>
		/// FK_KategorieID_BackReference
		/// </summary>
		[Association(ThisKey="ID", OtherKey="KategorieID", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<Mahlzeiten> KategorieIds { get; set; }

		/// <summary>
		/// OberKat
		/// </summary>
		[Association(ThisKey="Oberkategorie", OtherKey="ID", CanBeNull=true, Relationship=Relationship.ManyToOne, KeyName="OberKat", BackReferenceName="OberKatBackReferences")]
		public Kategorien OberKat { get; set; }

		/// <summary>
		/// OberKat_BackReference
		/// </summary>
		[Association(ThisKey="ID", OtherKey="Oberkategorie", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<Kategorien> OberKatBackReferences { get; set; }

		/// <summary>
		/// FK_Preis
		/// </summary>
		[Association(ThisKey="PreisID", OtherKey="ID", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="FK_Preis", BackReferenceName="Preis")]
		public Preise Prei { get; set; }

		#endregion
	}

	[Table("kommentare")]
	public partial class Kommentare
	{
		[PrimaryKey, Identity   ] public uint   ID         { get; set; } // int(10) unsigned
		[Column,        Nullable] public string Bemerkung  { get; set; } // varchar(255)
		[Column,     NotNull    ] public uint   Bewertung  { get; set; } // int(10) unsigned
		[Column,     NotNull    ] public uint   MahlzeitID { get; set; } // int(10) unsigned
		[Column,     NotNull    ] public uint   StudentID  { get; set; } // int(10) unsigned

		#region Associations

		/// <summary>
		/// FK_MahlzeitIDKommentare
		/// </summary>
		[Association(ThisKey="MahlzeitID", OtherKey="ID", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="FK_MahlzeitIDKommentare", BackReferenceName="MahlzeitIDKommentares")]
		public Mahlzeiten Mahlzeit { get; set; }

		/// <summary>
		/// FK_Student
		/// </summary>
		[Association(ThisKey="StudentID", OtherKey="Nummer", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="FK_Student", BackReferenceName="Students")]
		public Studenten Student { get; set; }

		#endregion
	}

	[Table("mahlzeiten")]
	public partial class Mahlzeiten
	{
		[Column,     NotNull    ] public uint   Vorrat       { get; set; } // int(10) unsigned
		[Column,        Nullable] public bool?  Verfuegbar   { get; set; } // tinyint(1)
		[PrimaryKey, Identity   ] public uint   ID           { get; set; } // int(10) unsigned
		[Column,     NotNull    ] public uint   KategorieID  { get; set; } // int(10) unsigned
		[Column,     NotNull    ] public uint   PreisID      { get; set; } // int(10) unsigned
		[Column,     NotNull    ] public string Beschreibung { get; set; } // varchar(140)
		[Column,        Nullable] public string Name         { get; set; } // varchar(25)

		#region Associations

		/// <summary>
		/// FK_KategorieID
		/// </summary>
		[Association(ThisKey="KategorieID", OtherKey="ID", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="FK_KategorieID", BackReferenceName="KategorieIds")]
		public Kategorien Kategorie { get; set; }

		/// <summary>
		/// FK_MahlzeitBilder_BackReference
		/// </summary>
		[Association(ThisKey="ID", OtherKey="MahlzeitID", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<Mahlzeitenbilder> MahlzeitBilders { get; set; }

		/// <summary>
		/// FK_MahlzeitIDBestellung_BackReference
		/// </summary>
		[Association(ThisKey="ID", OtherKey="MahlzeitID", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<Mahlzeitenbestellungen> MahlzeitIDBestellungs { get; set; }

		/// <summary>
		/// FK_MahlzeitIDKommentare_BackReference
		/// </summary>
		[Association(ThisKey="ID", OtherKey="MahlzeitID", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<Kommentare> MahlzeitIDKommentares { get; set; }

		/// <summary>
		/// FK_MahlzeitID_BackReference
		/// </summary>
		[Association(ThisKey="ID", OtherKey="MahlzeitID", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<Mahlzeitendeklarationen> MahlzeitIds { get; set; }

		/// <summary>
		/// FK_MahlzeitIDZutat_BackReference
		/// </summary>
		[Association(ThisKey="ID", OtherKey="MahlzeitID", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<Mahlzeitenzutat> MahlzeitIDZutats { get; set; }

		/// <summary>
		/// FK_PreisID
		/// </summary>
		[Association(ThisKey="PreisID", OtherKey="ID", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="FK_PreisID", BackReferenceName="PreisIds")]
		public Preise Prei { get; set; }

		#endregion
	}

	[Table("mahlzeitenbestellungen")]
	public partial class Mahlzeitenbestellungen
	{
		[PrimaryKey(1), NotNull] public uint MahlzeitID   { get; set; } // int(10) unsigned
		[PrimaryKey(2), NotNull] public uint BestellungID { get; set; } // int(10) unsigned
		[Column,        NotNull] public uint Anzahl       { get; set; } // int(10) unsigned

		#region Associations

		/// <summary>
		/// FK_Bestellung
		/// </summary>
		[Association(ThisKey="BestellungID", OtherKey="Nummer", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="FK_Bestellung", BackReferenceName="Bestellungs")]
		public Bestellungen Bestellung { get; set; }

		/// <summary>
		/// FK_MahlzeitIDBestellung
		/// </summary>
		[Association(ThisKey="MahlzeitID", OtherKey="ID", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="FK_MahlzeitIDBestellung", BackReferenceName="MahlzeitIDBestellungs")]
		public Mahlzeiten Mahlzeit { get; set; }

		#endregion
	}

	[Table("mahlzeitenbilder")]
	public partial class Mahlzeitenbilder
	{
		[PrimaryKey(1), NotNull] public uint MahlzeitID { get; set; } // int(10) unsigned
		[PrimaryKey(2), NotNull] public uint BildID     { get; set; } // int(10) unsigned

		#region Associations

		/// <summary>
		/// FK_Bild
		/// </summary>
		[Association(ThisKey="BildID", OtherKey="ID", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="FK_Bild", BackReferenceName="Bilds")]
		public Bilder Bild { get; set; }

		/// <summary>
		/// FK_MahlzeitBilder
		/// </summary>
		[Association(ThisKey="MahlzeitID", OtherKey="ID", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="FK_MahlzeitBilder", BackReferenceName="MahlzeitBilders")]
		public Mahlzeiten Mahlzeit { get; set; }

		#endregion
	}

	[Table("mahlzeitendeklarationen")]
	public partial class Mahlzeitendeklarationen
	{
		[PrimaryKey(1), NotNull] public uint   MahlzeitID         { get; set; } // int(10) unsigned
		[PrimaryKey(2), NotNull] public string DeklarationZeichen { get; set; } // varchar(2)

		#region Associations

		/// <summary>
		/// FK_DeklarationZeichen
		/// </summary>
		[Association(ThisKey="DeklarationZeichen", OtherKey="Zeichen", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="FK_DeklarationZeichen", BackReferenceName="DeklarationZeichens")]
		public Deklarationen FkDeklarationZeichen { get; set; }

		/// <summary>
		/// FK_MahlzeitID
		/// </summary>
		[Association(ThisKey="MahlzeitID", OtherKey="ID", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="FK_MahlzeitID", BackReferenceName="MahlzeitIds")]
		public Mahlzeiten Mahlzeit { get; set; }

		#endregion
	}

	[Table("mahlzeitenzutat")]
	public partial class Mahlzeitenzutat
	{
		[PrimaryKey(1), NotNull] public uint MahlzeitID { get; set; } // int(10) unsigned
		[PrimaryKey(2), NotNull] public int  ZutatID    { get; set; } // mediumint(5)

		#region Associations

		/// <summary>
		/// FK_MahlzeitIDZutat
		/// </summary>
		[Association(ThisKey="MahlzeitID", OtherKey="ID", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="FK_MahlzeitIDZutat", BackReferenceName="MahlzeitIDZutats")]
		public Mahlzeiten Mahlzeit { get; set; }

		/// <summary>
		/// FK_Zutat
		/// </summary>
		[Association(ThisKey="ZutatID", OtherKey="ID", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="FK_Zutat", BackReferenceName="Zutats")]
		public Zutaten Zutat { get; set; }

		#endregion
	}

	[Table("mitarbeiter")]
	public partial class Mitarbeiter
	{
		[PrimaryKey, NotNull    ] public uint   Nummer  { get; set; } // int(10) unsigned
		[Column,        Nullable] public string Buero   { get; set; } // varchar(25)
		[Column,        Nullable] public string Telefon { get; set; } // varchar(25)

		#region Associations

		/// <summary>
		/// FK_MitarbeiterID
		/// </summary>
		[Association(ThisKey="Nummer", OtherKey="Nummer", CanBeNull=false, Relationship=Relationship.OneToOne, KeyName="FK_MitarbeiterID", BackReferenceName="MitarbeiterID")]
		public Fhangehoerige MitarbeiterID { get; set; }

		#endregion
	}

	[Table("preise")]
	public partial class Preise
	{
		[PrimaryKey(1), Identity   ] public uint     ID             { get; set; } // int(10) unsigned
		[PrimaryKey(2), NotNull    ] public uint     Jahr           { get; set; } // int(10) unsigned
		[Column,        NotNull    ] public decimal  Gastpreis      { get; set; } // decimal(4,2)
		[Column,           Nullable] public decimal? Studentenpreis { get; set; } // decimal(4,2)
		[Column,           Nullable] public decimal? MAPreis        { get; set; } // decimal(4,2)

		#region Associations

		/// <summary>
		/// FK_Preis_BackReference
		/// </summary>
		[Association(ThisKey="ID", OtherKey="PreisID", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<Kategorien> Preis { get; set; }

		/// <summary>
		/// FK_PreisID_BackReference
		/// </summary>
		[Association(ThisKey="ID", OtherKey="PreisID", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<Mahlzeiten> PreisIds { get; set; }

		#endregion
	}

	[Table("studenten")]
	public partial class Studenten
	{
		[PrimaryKey, NotNull] public uint   Nummer         { get; set; } // int(10) unsigned
		[Column,     NotNull] public string Studiengang    { get; set; } // varchar(3)
		[Column,     NotNull] public int    Matrikelnummer { get; set; } // int(11)

		#region Associations

		/// <summary>
		/// FK_StudentenID
		/// </summary>
		[Association(ThisKey="Nummer", OtherKey="Nummer", CanBeNull=false, Relationship=Relationship.OneToOne, KeyName="FK_StudentenID", BackReferenceName="StudentenID")]
		public Fhangehoerige StudentenID { get; set; }

		/// <summary>
		/// FK_Student_BackReference
		/// </summary>
		[Association(ThisKey="Nummer", OtherKey="StudentID", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<Kommentare> Students { get; set; }

		#endregion
	}

	[Table("v_rolle", IsView=true)]
	public partial class VRolle
	{
		[Column, NotNull    ] public uint   Nummer     { get; set; } // int(10) unsigned
		[Column, NotNull    ] public string Nutzername { get; set; } // varchar(100)
		[Column,    Nullable] public string Hashk      { get; set; } // varchar(24)
		[Column,    Nullable] public string Salt       { get; set; } // varchar(32)
		[Column,    Nullable] public uint?  GastNum    { get; set; } // int(10) unsigned
		[Column,    Nullable] public uint?  StudentNum { get; set; } // int(10) unsigned
		[Column,    Nullable] public uint?  MANum      { get; set; } // int(10) unsigned
		[Column, NotNull    ] public string Rolle      { get; set; } // varchar(11)
	}

	[Table("zutaten")]
	public partial class Zutaten
	{
		[PrimaryKey, NotNull] public int    ID          { get; set; } // mediumint(5)
		[Column,     NotNull] public string Name        { get; set; } // varchar(100)
		[Column,     NotNull] public bool   Bio         { get; set; } // tinyint(1)
		[Column,     NotNull] public bool   Vegetarisch { get; set; } // tinyint(1)
		[Column,     NotNull] public bool   Vegan       { get; set; } // tinyint(1)
		[Column,     NotNull] public bool   Glutenfrei  { get; set; } // tinyint(1)

		#region Associations

		/// <summary>
		/// FK_Zutat_BackReference
		/// </summary>
		[Association(ThisKey="ID", OtherKey="ZutatID", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<Mahlzeitenzutat> Zutats { get; set; }

		#endregion
	}

	public static partial class TableExtensions
	{
		public static Benutzer Find(this ITable<Benutzer> table, uint Nummer)
		{
			return table.FirstOrDefault(t =>
				t.Nummer == Nummer);
		}

		public static Benutzerbefreundetmit Find(this ITable<Benutzerbefreundetmit> table, uint Benutzer1ID, uint Benutzer2ID)
		{
			return table.FirstOrDefault(t =>
				t.Benutzer1ID == Benutzer1ID &&
				t.Benutzer2ID == Benutzer2ID);
		}

		public static Bestellungen Find(this ITable<Bestellungen> table, uint Nummer)
		{
			return table.FirstOrDefault(t =>
				t.Nummer == Nummer);
		}

		public static Bilder Find(this ITable<Bilder> table, uint ID)
		{
			return table.FirstOrDefault(t =>
				t.ID == ID);
		}

		public static Deklarationen Find(this ITable<Deklarationen> table, string Zeichen)
		{
			return table.FirstOrDefault(t =>
				t.Zeichen == Zeichen);
		}

		public static Fachbereiche Find(this ITable<Fachbereiche> table, uint ID)
		{
			return table.FirstOrDefault(t =>
				t.ID == ID);
		}

		public static Fhangehoerige Find(this ITable<Fhangehoerige> table, uint Nummer)
		{
			return table.FirstOrDefault(t =>
				t.Nummer == Nummer);
		}

		public static Fhangehoerigerfachbereich Find(this ITable<Fhangehoerigerfachbereich> table, uint FHAngehoeriger, uint Fachbereich)
		{
			return table.FirstOrDefault(t =>
				t.FHAngehoeriger == FHAngehoeriger &&
				t.Fachbereich    == Fachbereich);
		}

		public static Gaeste Find(this ITable<Gaeste> table, uint Nummer)
		{
			return table.FirstOrDefault(t =>
				t.Nummer == Nummer);
		}

		public static Kategorien Find(this ITable<Kategorien> table, uint ID)
		{
			return table.FirstOrDefault(t =>
				t.ID == ID);
		}

		public static Kommentare Find(this ITable<Kommentare> table, uint ID)
		{
			return table.FirstOrDefault(t =>
				t.ID == ID);
		}

		public static Mahlzeiten Find(this ITable<Mahlzeiten> table, uint ID)
		{
			return table.FirstOrDefault(t =>
				t.ID == ID);
		}

		public static Mahlzeitenbestellungen Find(this ITable<Mahlzeitenbestellungen> table, uint MahlzeitID, uint BestellungID)
		{
			return table.FirstOrDefault(t =>
				t.MahlzeitID   == MahlzeitID &&
				t.BestellungID == BestellungID);
		}

		public static Mahlzeitenbilder Find(this ITable<Mahlzeitenbilder> table, uint MahlzeitID, uint BildID)
		{
			return table.FirstOrDefault(t =>
				t.MahlzeitID == MahlzeitID &&
				t.BildID     == BildID);
		}

		public static Mahlzeitendeklarationen Find(this ITable<Mahlzeitendeklarationen> table, uint MahlzeitID, string DeklarationZeichen)
		{
			return table.FirstOrDefault(t =>
				t.MahlzeitID         == MahlzeitID &&
				t.DeklarationZeichen == DeklarationZeichen);
		}

		public static Mahlzeitenzutat Find(this ITable<Mahlzeitenzutat> table, uint MahlzeitID, int ZutatID)
		{
			return table.FirstOrDefault(t =>
				t.MahlzeitID == MahlzeitID &&
				t.ZutatID    == ZutatID);
		}

		public static Mitarbeiter Find(this ITable<Mitarbeiter> table, uint Nummer)
		{
			return table.FirstOrDefault(t =>
				t.Nummer == Nummer);
		}

		public static Preise Find(this ITable<Preise> table, uint ID, uint Jahr)
		{
			return table.FirstOrDefault(t =>
				t.ID   == ID &&
				t.Jahr == Jahr);
		}

		public static Studenten Find(this ITable<Studenten> table, uint Nummer)
		{
			return table.FirstOrDefault(t =>
				t.Nummer == Nummer);
		}

		public static Zutaten Find(this ITable<Zutaten> table, int ID)
		{
			return table.FirstOrDefault(t =>
				t.ID == ID);
		}
	}
}