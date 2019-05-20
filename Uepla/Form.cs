using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Uepla
{
    public enum Mikroorganizma
    {
        CAMPYLOBACTER,
        SALMONELLA,
        SHIGELLA,
        VTEC,
    }

    public enum OrnekTipi
    {
        Bilinmiyor,
        BOS,
        Gaita,
        Idrar,
        Diger
    }

    public enum Cinsiyet
    {
        Bilinmiyor,
        Kadın,
        Erkek
    }


    public enum Tur
    {
        Coli,
        Jejuni,
        Iari
    }

    public enum TestOnay
    {
        Hayır,
        Evet
    }

    public enum AmdRehberi
    {
        CLSI,
        EUCAST
    }

    public enum Yontem
    {
        DiskDifüzyon,
        ETest
    }


    public enum SirDurumu
    {
        Çalışılmadı,
        Duyarlı,
        OrtaDuyarlı,
        Dirençli
    }

    public enum Antibiyotik
    {
        Ampisilin,
        Kloramfenikol,
        Gentamisin,
        Kanamisin,
        Streptomisin,
        TrimetorimSülfametoksazol,
        Trimetoprim,
        Sülfonamid,
        Tetrasiklin,
        Nalidiksikasit,
        Siprofloksasin,
        Sefotaksim,
        Seftazidim
    }

    public class Form
    {
        public int Id { get; set; }
        public Mikroorganizma? Mikroorganizma { get; set; }

        public OrnekTipi? OrnekTipi { get; set; }

        public DateTime? SonucCikisTarihi { get; set; }
        public int? ProtokolNumarasi { get; set; }

        public Cinsiyet? Cinsiyet { get; set; }

        public int? Yas { get; set; }

        public Tur? Tur { get; set; }
        public TestOnay? TestUygulandiMi { get; set; }
        public AmdRehberi? AmdRehberi { get; set; }
        public Yontem? Yontem { get; set; }

        public int? ZoneCapi { get; set; }
        public SirDurumu? SirDurumu { get; set; }
        public Antibiyotik? Antibiyotik { get; set; }

        public string Aciklamalar { get; set; }
    }
}
