﻿using MusicStore.WebAPI.Models.Entities;
using System.Collections.Generic;
using System.Linq;
namespace MusicStore.WebAPI.Models.Data
{
    public class MusicStoreData
    {
        public static List<Album> GetAlbums()
        {
             return new List<Album>
             {
             new Album { Title = "The Best Of Men At Work", Genre = GetGenres().Single(g => g.Name
            == "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Men At Work"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "A Copland Celebration, Vol. I", Genre = GetGenres().Single(g =>
            g.Name == "Classical"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Aaron Copland & London Symphony Orchestra"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "Worlds", Genre = GetGenres().Single(g => g.Name == "Jazz"), Price
            = 8.99M, Artist = GetArtists().Single(a => a.Name == "Aaron Goldberg"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "For Those About To Rock We Salute You", Genre =
            GetGenres().Single(g => g.Name == "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name ==
            "AC/DC"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "Let There Be Rock", Genre = GetGenres().Single(g => g.Name ==
            "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "AC/DC"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Balls to the Wall", Genre = GetGenres().Single(g => g.Name ==
            "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Accept"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Restless and Wild", Genre = GetGenres().Single(g => g.Name ==
            "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Accept"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Górecki: Symphony No. 3", Genre = GetGenres().Single(g => g.Name
            == "Classical"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Adrian Leaper & Doreen deFeis"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "Big Ones", Genre = GetGenres().Single(g => g.Name == "Rock"),
            Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Aerosmith"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Quiet Songs", Genre = GetGenres().Single(g => g.Name == "Jazz"),
            Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Aisha Duo"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Jagged Little Pill", Genre = GetGenres().Single(g => g.Name ==
            "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Alanis Morissette"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Facelift", Genre = GetGenres().Single(g => g.Name == "Rock"),
            Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Alice In Chains"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Frank", Genre = GetGenres().Single(g => g.Name == "Pop"), Price =
            8.99M, Artist = GetArtists().Single(a => a.Name == "Amy Winehouse"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Ring My Bell", Genre = GetGenres().Single(g => g.Name == "Disco"),
            Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Anita Ward"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Chill: Brazil (Disc 2)", Genre = GetGenres().Single(g => g.Name ==
            "Latin"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Antônio Carlos Jobim"),
            AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "Warner 25 Anos", Genre = GetGenres().Single(g => g.Name ==
            "Jazz"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Antônio Carlos Jobim"),
            AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "Plays Metallica By Four Cellos", Genre = GetGenres().Single(g =>
            g.Name == "Metal"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Apocalyptica"),
            AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "Revelations", Genre = GetGenres().Single(g => g.Name ==
            "Alternative"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Audioslave"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Audioslave", Genre = GetGenres().Single(g => g.Name == "Rock"),
            Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Audioslave"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "The Last Night of the Proms", Genre = GetGenres().Single(g =>
            g.Name == "Classical"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Barry Wordsworth & BBC Concert Orchestra"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "Sibelius: Finlandia", Genre = GetGenres().Single(g => g.Name ==
            "Classical"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Berliner Philharmoniker & Hans Rosbaud"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "Mozart: Symphonies Nos. 40 & 41", Genre = GetGenres().Single(g =>
            g.Name == "Classical"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Berliner Philharmoniker & Herbert Von Karajan"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "The Best Of Billy Cobham", Genre = GetGenres().Single(g => g.Name
            == "Jazz"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Billy Cobham"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Alcohol Fueled Brewtality Live! [Disc 1]", Genre =
            GetGenres().Single(g => g.Name == "Metal"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name ==
            "Black Label Society"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "Alcohol Fueled Brewtality Live! [Disc 2]", Genre =
            GetGenres().Single(g => g.Name == "Metal"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name ==
            "Black Label Society"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "Black Sabbath Vol. 4 (Remaster)", Genre = GetGenres().Single(g =>
            g.Name == "Metal"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Black Sabbath"),
            AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "Black Sabbath", Genre = GetGenres().Single(g => g.Name ==
            "Metal"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Black Sabbath"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Carmina Burana", Genre = GetGenres().Single(g => g.Name ==
            "Classical"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Boston Symphony Orchestra & Seiji Ozawa"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "A Soprano Inspired", Genre = GetGenres().Single(g => g.Name ==
            "Classical"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Britten Sinfonia, Ivor Bolton & Lesley Garrett"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "Chemical Wedding", Genre = GetGenres().Single(g => g.Name ==
            "Metal"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Bruce Dickinson"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Prenda Minha", Genre = GetGenres().Single(g => g.Name == "Latin"),
            Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Caetano Veloso"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Sozinho Remix Ao Vivo", Genre = GetGenres().Single(g => g.Name ==
            "Latin"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Caetano Veloso"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Cake: B-Sides and Rarities", Genre = GetGenres().Single(g =>
            g.Name == "Alternative"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Cake"),
            AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "Carried to Dust (Bonus Track Version)", Genre =
            GetGenres().Single(g => g.Name == "Alternative"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name ==
            "Calexico"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "Cássia Eller - Sem Limite [Disc 1]", Genre = GetGenres().Single(g
            => g.Name == "Latin"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Cássia Eller"),
            AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "Le Freak", Genre = GetGenres().Single(g => g.Name == "Disco"),
            Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Chic"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Scheherazade", Genre = GetGenres().Single(g => g.Name ==
            "Classical"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Chicago Symphony Orchestra & Fritz Reiner"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "Minha Historia", Genre = GetGenres().Single(g => g.Name ==
            "Latin"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Chico Buarque"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Afrociberdelia", Genre = GetGenres().Single(g => g.Name ==
            "Latin"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Chico Science & Nação Zumbi"),
            AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "Da Lama Ao Caos", Genre = GetGenres().Single(g => g.Name ==
            "Latin"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Chico Science & Nação Zumbi"),
            AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "Carry On", Genre = GetGenres().Single(g => g.Name ==
            "Alternative"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Chris Cornell"),
            AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "SCRIABIN: Vers la flamme", Genre = GetGenres().Single(g => g.Name
            == "Classical"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Christopher O'Riley"),
            AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "Acústico MTV [Live]", Genre = GetGenres().Single(g => g.Name ==
            "Reggae"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Cidade Negra"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Cidade Negra - Hits", Genre = GetGenres().Single(g => g.Name ==
            "Reggae"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Cidade Negra"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Na Pista", Genre = GetGenres().Single(g => g.Name == "Latin"),
            Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Cláudio Zoli"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Chronicle, Vol. 1", Genre = GetGenres().Single(g => g.Name ==
            "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Creedence Clearwater Revival"),
            AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "Chronicle, Vol. 2", Genre = GetGenres().Single(g => g.Name ==
            "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Creedence Clearwater Revival"),
            AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "Into The Light", Genre = GetGenres().Single(g => g.Name ==
            "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "David Coverdale"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Come Taste The Band", Genre = GetGenres().Single(g => g.Name ==
            "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Deep Purple"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Deep Purple In Rock", Genre = GetGenres().Single(g => g.Name ==
            "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Deep Purple"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Fireball", Genre = GetGenres().Single(g => g.Name == "Rock"),
            Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Deep Purple"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Machine Head", Genre = GetGenres().Single(g => g.Name == "Rock"),
            Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Deep Purple"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "MK III The Final Concerts [Disc 1]", Genre = GetGenres().Single(g
            => g.Name == "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Deep Purple"),
            AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "Purpendicular", Genre = GetGenres().Single(g => g.Name == "Rock"),
            Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Deep Purple"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Slaves And Masters", Genre = GetGenres().Single(g => g.Name ==
            "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Deep Purple"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Stormbringer", Genre = GetGenres().Single(g => g.Name == "Rock"),
            Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Deep Purple"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "The Battle Rages On", Genre = GetGenres().Single(g => g.Name ==
            "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Deep Purple"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "The Final Concerts (Disc 2)", Genre = GetGenres().Single(g =>
            g.Name == "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Deep Purple"),
            AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "Outbreak", Genre = GetGenres().Single(g => g.Name == "Jazz"),
            Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Dennis Chambers"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Djavan Ao Vivo - Vol. 02", Genre = GetGenres().Single(g => g.Name
            == "Latin"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Djavan"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Djavan Ao Vivo - Vol. 1", Genre = GetGenres().Single(g => g.Name
            == "Latin"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Djavan"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "MacArthur Park Suite", Genre = GetGenres().Single(g => g.Name ==
            "Disco"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Donna Summer"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Un-Led-Ed", Genre = GetGenres().Single(g => g.Name == "Rock"),
            Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Dread Zeppelin"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "The Best of Ed Motta", Genre = GetGenres().Single(g => g.Name ==
            "Latin"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Ed Motta"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Adams, John: The Chairman Dances", Genre = GetGenres().Single(g =>
            g.Name == "Classical"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Edo de Waart & San Francisco Symphony"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "Elis Regina-Minha História", Genre = GetGenres().Single(g =>
            g.Name == "Latin"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Elis Regina"),
            AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "Pachelbel: Canon & Gigue", Genre = GetGenres().Single(g => g.Name
            == "Classical"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "English Concert & Trevor Pinnock"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "Unplugged", Genre = GetGenres().Single(g => g.Name == "Latin"),
            Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Eric Clapton"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "The Cream Of Clapton", Genre = GetGenres().Single(g => g.Name ==
            "Blues"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Eric Clapton"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Unplugged", Genre = GetGenres().Single(g => g.Name == "Blues"),
            Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Eric Clapton"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Respighi:Pines of Rome", Genre = GetGenres().Single(g => g.Name ==
            "Classical"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Eugene Ormandy"), AlbumArtUrl
            = "/Content/Images/placeholder.gif" },
             new Album { Title = "Strauss: Waltzes", Genre = GetGenres().Single(g => g.Name ==
            "Classical"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Eugene Ormandy"), AlbumArtUrl
            = "/Content/Images/placeholder.gif" },
             new Album { Title = "King For A Day Fool For A Lifetime", Genre = GetGenres().Single(g
            => g.Name == "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Faith No More"),
            AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "Deixa Entrar", Genre = GetGenres().Single(g => g.Name == "Latin"),
            Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Falamansa"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "In Your Honor [Disc 1]", Genre = GetGenres().Single(g => g.Name ==
            "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Foo Fighters"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "In Your Honor [Disc 2]", Genre = GetGenres().Single(g => g.Name ==
            "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Foo Fighters"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "The Colour And The Shape", Genre = GetGenres().Single(g => g.Name
            == "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Foo Fighters"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Bongo Fury", Genre = GetGenres().Single(g => g.Name == "Rock"),
            Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Frank Zappa & Captain Beefheart"),
            AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "Roda De Funk", Genre = GetGenres().Single(g => g.Name == "Latin"),
            Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Funk Como Le Gusta"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Quanta Gente Veio Ver (Live)", Genre = GetGenres().Single(g =>
            g.Name == "Latin"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Gilberto Gil"),
            AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "Quanta Gente Veio ver--Bônus De Carnaval", Genre =
            GetGenres().Single(g => g.Name == "Jazz"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name ==
            "Gilberto Gil"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "Faceless", Genre = GetGenres().Single(g => g.Name == "Metal"),
            Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Godsmack"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Meus Momentos", Genre = GetGenres().Single(g => g.Name ==
            "Latin"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Gonzaguinha"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Nielsen: The Six Symphonies", Genre = GetGenres().Single(g =>
            g.Name == "Classical"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Göteborgs Symfoniker & Neeme Järvi"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "Appetite for Destruction", Genre = GetGenres().Single(g => g.Name
            == "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Guns N' Roses"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Use Your Illusion I", Genre = GetGenres().Single(g => g.Name ==
            "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Guns N' Roses"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Use Your Illusion II", Genre = GetGenres().Single(g => g.Name ==
            "Metal"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Guns N' Roses"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Blue Moods", Genre = GetGenres().Single(g => g.Name == "Jazz"),
            Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Incognito"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "A Matter of Life and Death", Genre = GetGenres().Single(g =>
            g.Name == "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Iron Maiden"),
            AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "Brave New World", Genre = GetGenres().Single(g => g.Name ==
            "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Iron Maiden"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Fear Of The Dark", Genre = GetGenres().Single(g => g.Name ==
            "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Iron Maiden"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Live At Donington 1992 (Disc 1)", Genre = GetGenres().Single(g =>
            g.Name == "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Iron Maiden"),
            AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "Live At Donington 1992 (Disc 2)", Genre = GetGenres().Single(g =>
            g.Name == "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Iron Maiden"),
            AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "Rock In Rio [CD2]", Genre = GetGenres().Single(g => g.Name ==
            "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Iron Maiden"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "The Number of The Beast", Genre = GetGenres().Single(g => g.Name
            == "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Iron Maiden"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "The X Factor", Genre = GetGenres().Single(g => g.Name == "Rock"),
            Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Iron Maiden"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Virtual XI", Genre = GetGenres().Single(g => g.Name == "Rock"),
            Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Iron Maiden"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "A Real Dead One", Genre = GetGenres().Single(g => g.Name ==
            "Metal"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Iron Maiden"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "A Real Live One", Genre = GetGenres().Single(g => g.Name ==
            "Metal"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Iron Maiden"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Live After Death", Genre = GetGenres().Single(g => g.Name ==
            "Metal"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Iron Maiden"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "No Prayer For The Dying", Genre = GetGenres().Single(g => g.Name
            == "Metal"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Iron Maiden"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Piece Of Mind", Genre = GetGenres().Single(g => g.Name ==
            "Metal"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Iron Maiden"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Powerslave", Genre = GetGenres().Single(g => g.Name == "Metal"),
            Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Iron Maiden"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Rock In Rio [CD1]", Genre = GetGenres().Single(g => g.Name ==
            "Metal"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Iron Maiden"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Rock In Rio [CD2]", Genre = GetGenres().Single(g => g.Name ==
            "Metal"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Iron Maiden"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Seventh Son of a Seventh Son", Genre = GetGenres().Single(g =>
            g.Name == "Metal"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Iron Maiden"),
            AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "Somewhere in Time", Genre = GetGenres().Single(g => g.Name ==
            "Metal"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Iron Maiden"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "The Number of The Beast", Genre = GetGenres().Single(g => g.Name
            == "Metal"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Iron Maiden"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Iron Maiden", Genre = GetGenres().Single(g => g.Name == "Blues"),
            Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Iron Maiden"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Mascagni: Cavalleria Rusticana", Genre = GetGenres().Single(g =>
            g.Name == "Classical"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "James Levine"),
            AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "Emergency On Planet Earth", Genre = GetGenres().Single(g => g.Name
            == "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Jamiroquai"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Are You Experienced?", Genre = GetGenres().Single(g => g.Name ==
            "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Jimi Hendrix"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Surfing with the Alien (Remastered)", Genre = GetGenres().Single(g
            => g.Name == "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Joe Satriani"),
            AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "Jorge Ben Jor 25 Anos", Genre = GetGenres().Single(g => g.Name ==
            "Latin"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Jorge Ben"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Jota Quest-1995", Genre = GetGenres().Single(g => g.Name ==
            "Latin"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Jota Quest"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Living After Midnight", Genre = GetGenres().Single(g => g.Name ==
            "Metal"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Judas Priest"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Weill: The Seven Deadly Sins", Genre = GetGenres().Single(g =>
            g.Name == "Classical"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Kent Nagano and Orchestre de l'Opéra de Lyon"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "Greatest Kiss", Genre = GetGenres().Single(g => g.Name == "Rock"),
            Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Kiss"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Unplugged [Live]", Genre = GetGenres().Single(g => g.Name ==
            "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Kiss"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "BBC Sessions [Disc 1] [Live]", Genre = GetGenres().Single(g =>
            g.Name == "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Led Zeppelin"),
            AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "BBC Sessions [Disc 2] [Live]", Genre = GetGenres().Single(g =>
            g.Name == "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Led Zeppelin"),
            AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "Coda", Genre = GetGenres().Single(g => g.Name == "Rock"), Price =
            8.99M, Artist = GetArtists().Single(a => a.Name == "Led Zeppelin"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Houses Of The Holy", Genre = GetGenres().Single(g => g.Name ==
            "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Led Zeppelin"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "In Through The Out Door", Genre = GetGenres().Single(g => g.Name
            == "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Led Zeppelin"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "IV", Genre = GetGenres().Single(g => g.Name == "Rock"), Price =
            8.99M, Artist = GetArtists().Single(a => a.Name == "Led Zeppelin"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Led Zeppelin I", Genre = GetGenres().Single(g => g.Name ==
            "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Led Zeppelin"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Led Zeppelin II", Genre = GetGenres().Single(g => g.Name ==
            "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Led Zeppelin"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Led Zeppelin III", Genre = GetGenres().Single(g => g.Name ==
            "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Led Zeppelin"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Physical Graffiti [Disc 1]", Genre = GetGenres().Single(g =>
            g.Name == "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Led Zeppelin"),
            AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "Physical Graffiti [Disc 2]", Genre = GetGenres().Single(g =>
            g.Name == "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Led Zeppelin"),
            AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "Presence", Genre = GetGenres().Single(g => g.Name == "Rock"),
            Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Led Zeppelin"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "The Song Remains The Same (Disc 1)", Genre = GetGenres().Single(g
            => g.Name == "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Led Zeppelin"),
            AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "The Song Remains The Same (Disc 2)", Genre = GetGenres().Single(g
            => g.Name == "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Led Zeppelin"),
            AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "Mais Do Mesmo", Genre = GetGenres().Single(g => g.Name ==
            "Latin"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Legião Urbana"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Greatest Hits", Genre = GetGenres().Single(g => g.Name ==
            "Reggae"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Lenny Kravitz"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Greatest Hits", Genre = GetGenres().Single(g => g.Name == "Rock"),
            Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Lenny Kravitz"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Greatest Hits", Genre = GetGenres().Single(g => g.Name ==
            "Metal"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Lenny Kravitz"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Tchaikovsky: The Nutcracker", Genre = GetGenres().Single(g =>
            g.Name == "Classical"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "London Symphony Orchestra & Sir Charles Mackerras"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "Duos II", Genre = GetGenres().Single(g => g.Name == "Latin"),
            Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Luciana Souza/Romero Lubambo"), AlbumArtUrl
            = "/Content/Images/placeholder.gif" },
             new Album { Title = "Chill: Brazil (Disc 1)", Genre = GetGenres().Single(g => g.Name ==
            "Latin"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Marcos Valle"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Misplaced Childhood", Genre = GetGenres().Single(g => g.Name ==
            "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Marillion"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Barulhinho Bom", Genre = GetGenres().Single(g => g.Name ==
            "Latin"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Marisa Monte"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Szymanowski: Piano Works, Vol. 1", Genre = GetGenres().Single(g =>
            g.Name == "Classical"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Martin Roscoe"),
            AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "...And Justice For All", Genre = GetGenres().Single(g => g.Name ==
            "Metal"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Metallica"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Black Album", Genre = GetGenres().Single(g => g.Name == "Metal"),
            Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Metallica"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Garage Inc. (Disc 1)", Genre = GetGenres().Single(g => g.Name ==
            "Metal"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Metallica"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Garage Inc. (Disc 2)", Genre = GetGenres().Single(g => g.Name ==
            "Metal"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Metallica"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Load", Genre = GetGenres().Single(g => g.Name == "Metal"), Price =
            8.99M, Artist = GetArtists().Single(a => a.Name == "Metallica"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Master Of Puppets", Genre = GetGenres().Single(g => g.Name ==
            "Metal"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Metallica"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "ReLoad", Genre = GetGenres().Single(g => g.Name == "Metal"), Price
            = 8.99M, Artist = GetArtists().Single(a => a.Name == "Metallica"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Ride The Lightning", Genre = GetGenres().Single(g => g.Name ==
            "Metal"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Metallica"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "St. Anger", Genre = GetGenres().Single(g => g.Name == "Metal"),
            Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Metallica"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Berlioz: Symphonie Fantastique", Genre = GetGenres().Single(g =>
            g.Name == "Classical"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Michael Tilson Thomas & San Francisco Symphony"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "Prokofiev: Romeo & Juliet", Genre = GetGenres().Single(g => g.Name
            == "Classical"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Michael Tilson Thomas & San Francisco Symphony"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "Miles Ahead", Genre = GetGenres().Single(g => g.Name == "Jazz"),
            Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Miles Davis"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "The Essential Miles Davis [Disc 1]", Genre = GetGenres().Single(g
            => g.Name == "Jazz"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Miles Davis"),
            AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "The Essential Miles Davis [Disc 2]", Genre = GetGenres().Single(g
            => g.Name == "Jazz"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Miles Davis"),
            AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "Milton Nascimento Ao Vivo", Genre = GetGenres().Single(g => g.Name
            == "Latin"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Milton Nascimento"),
            AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "Minas", Genre = GetGenres().Single(g => g.Name == "Latin"), Price
            = 8.99M, Artist = GetArtists().Single(a => a.Name == "Milton Nascimento"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Motley Crue Greatest Hits", Genre = GetGenres().Single(g => g.Name
            == "Metal"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Mötley Crüe"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Ace Of Spades", Genre = GetGenres().Single(g => g.Name ==
            "Metal"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Motörhead"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Mozart: Chamber Music", Genre = GetGenres().Single(g => g.Name ==
            "Classical"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Nash Ensemble"), AlbumArtUrl
            = "/Content/Images/placeholder.gif" },
             new Album { Title = "The Best of Beethoven", Genre = GetGenres().Single(g => g.Name ==
            "Classical"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Nicolaus Esterhazy Sinfonia"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "Nevermind", Genre = GetGenres().Single(g => g.Name == "Rock"),
            Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Nirvana"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Compositores", Genre = GetGenres().Single(g => g.Name == "Rock"),
            Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "O Terço"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Olodum", Genre = GetGenres().Single(g => g.Name == "Latin"), Price
            = 8.99M, Artist = GetArtists().Single(a => a.Name == "Olodum"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Bach: The Brandenburg Concertos", Genre = GetGenres().Single(g =>
            g.Name == "Classical"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Orchestra of The Age of Enlightenment"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "Acústico MTV", Genre = GetGenres().Single(g => g.Name == "Latin"),
            Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Os Paralamas Do Sucesso"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Arquivo II", Genre = GetGenres().Single(g => g.Name == "Latin"),
            Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Os Paralamas Do Sucesso"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Arquivo Os Paralamas Do Sucesso", Genre = GetGenres().Single(g =>
            g.Name == "Latin"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Os Paralamas Do Sucesso"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "Tribute", Genre = GetGenres().Single(g => g.Name == "Metal"),
            Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Ozzy Osbourne"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Bark at the Moon (Remastered)", Genre = GetGenres().Single(g =>
            g.Name == "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Ozzy Osbourne"),
            AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "Blizzard of Ozz", Genre = GetGenres().Single(g => g.Name ==
            "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Ozzy Osbourne"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Diary of a Madman (Remastered)", Genre = GetGenres().Single(g =>
            g.Name == "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Ozzy Osbourne"),
            AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "No More Tears (Remastered)", Genre = GetGenres().Single(g =>
            g.Name == "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Ozzy Osbourne"),
            AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "Speak of the Devil", Genre = GetGenres().Single(g => g.Name ==
            "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Ozzy Osbourne"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Walking Into Clarksdale", Genre = GetGenres().Single(g => g.Name
            == "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Page & Plant"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "The Beast Live", Genre = GetGenres().Single(g => g.Name ==
            "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Paul D'Ianno"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Live On Two Legs [Live]", Genre = GetGenres().Single(g => g.Name
            == "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Pearl Jam"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Riot Act", Genre = GetGenres().Single(g => g.Name == "Rock"),
            Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Pearl Jam"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Ten", Genre = GetGenres().Single(g => g.Name == "Rock"), Price =
            8.99M, Artist = GetArtists().Single(a => a.Name == "Pearl Jam"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Vs.", Genre = GetGenres().Single(g => g.Name == "Rock"), Price =
            8.99M, Artist = GetArtists().Single(a => a.Name == "Pearl Jam"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Dark Side Of The Moon", Genre = GetGenres().Single(g => g.Name ==
            "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Pink Floyd"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Greatest Hits I", Genre = GetGenres().Single(g => g.Name ==
            "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Queen"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Greatest Hits II", Genre = GetGenres().Single(g => g.Name ==
            "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Queen"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "News Of The World", Genre = GetGenres().Single(g => g.Name ==
            "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Queen"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "New Adventures In Hi-Fi", Genre = GetGenres().Single(g => g.Name
            == "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "R.E.M."), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Raul Seixas", Genre = GetGenres().Single(g => g.Name == "Rock"),
            Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Raul Seixas"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "By The Way", Genre = GetGenres().Single(g => g.Name == "Rock"),
            Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Red Hot Chili Peppers"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Californication", Genre = GetGenres().Single(g => g.Name ==
            "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Red Hot Chili Peppers"),
            AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "Purcell: The Fairy Queen", Genre = GetGenres().Single(g => g.Name
            == "Classical"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Roger Norrington, London Classical Players"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "Haydn: Symphonies 99 - 104", Genre = GetGenres().Single(g =>
            g.Name == "Classical"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Royal Philharmonic Orchestra & Sir Thomas Beecham"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "Retrospective I (1974-1980)", Genre = GetGenres().Single(g =>
            g.Name == "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Rush"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Santana - As Years Go By", Genre = GetGenres().Single(g => g.Name
            == "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Santana"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Santana Live", Genre = GetGenres().Single(g => g.Name == "Rock"),
            Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Santana"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Supernatural", Genre = GetGenres().Single(g => g.Name == "Rock"),
            Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Santana"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Handel: The Messiah (Highlights)", Genre = GetGenres().Single(g =>
            g.Name == "Classical"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Scholars Baroque Ensemble"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "Prokofiev: Symphony No.1", Genre = GetGenres().Single(g => g.Name
            == "Classical"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Sergei Prokofiev & Yuri Temirkanov"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "Wagner: Favourite Overtures", Genre = GetGenres().Single(g =>
            g.Name == "Classical"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Sir Georg Solti & Wiener Philharmoniker"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "Maquinarama", Genre = GetGenres().Single(g => g.Name == "Rock"),
            Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Skank"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "O Samba Poconé", Genre = GetGenres().Single(g => g.Name ==
            "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Skank"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "A-Sides", Genre = GetGenres().Single(g => g.Name == "Rock"), Price
            = 8.99M, Artist = GetArtists().Single(a => a.Name == "Soundgarden"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Heart of the Night", Genre = GetGenres().Single(g => g.Name ==
            "Jazz"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Spyro Gyra"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Morning Dance", Genre = GetGenres().Single(g => g.Name == "Jazz"),
            Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Spyro Gyra"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "In Step", Genre = GetGenres().Single(g => g.Name == "Blues"),
            Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Stevie Ray Vaughan & Double Trouble"),
            AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "Core", Genre = GetGenres().Single(g => g.Name == "Rock"), Price =
            8.99M, Artist = GetArtists().Single(a => a.Name == "Stone Temple Pilots"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Mezmerize", Genre = GetGenres().Single(g => g.Name == "Metal"),
            Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "System Of A Down"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Temple of the Dog", Genre = GetGenres().Single(g => g.Name ==
            "Alternative"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Temple of the Dog"),
            AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "[1997] Black Light Syndrome", Genre = GetGenres().Single(g =>
            g.Name == "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Terry Bozzio, Tony Levin & Steve Stevens"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "South American Getaway", Genre = GetGenres().Single(g => g.Name ==
            "Classical"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "The 12 Cellists of The Berlin Philharmonic"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "Live [Disc 1]", Genre = GetGenres().Single(g => g.Name ==
            "Blues"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "The Black Crowes"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Live [Disc 2]", Genre = GetGenres().Single(g => g.Name ==
            "Blues"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "The Black Crowes"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Beyond Good And Evil", Genre = GetGenres().Single(g => g.Name ==
            "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "The Cult"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "The Doors", Genre = GetGenres().Single(g => g.Name == "Rock"),
            Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "The Doors"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "English Renaissance", Genre = GetGenres().Single(g => g.Name ==
            "Classical"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "The King's Singers"),
            AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "The Police Greatest Hits", Genre = GetGenres().Single(g => g.Name
            == "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "The Police"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Every Kind of Light", Genre = GetGenres().Single(g => g.Name ==
            "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "The Posies"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Hot Rocks, 1964-1971 (Disc 1)", Genre = GetGenres().Single(g =>
            g.Name == "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "The Rolling Stones"),
            AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "No Security", Genre = GetGenres().Single(g => g.Name == "Rock"),
            Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "The Rolling Stones"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Voodoo Lounge", Genre = GetGenres().Single(g => g.Name == "Rock"),
            Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "The Rolling Stones"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "My Generation - The Very Best Of The Who", Genre =
            GetGenres().Single(g => g.Name == "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "The Who"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "Serie Sem Limite (Disc 1)", Genre = GetGenres().Single(g => g.Name
            == "Latin"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Tim Maia"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Serie Sem Limite (Disc 2)", Genre = GetGenres().Single(g => g.Name
            == "Latin"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Tim Maia"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Bach: Toccata & Fugue in D Minor", Genre = GetGenres().Single(g =>
            g.Name == "Classical"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Ton Koopman"),
            AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "Achtung Baby", Genre = GetGenres().Single(g => g.Name == "Rock"),
            Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "U2"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "B-Sides 1980-1990", Genre = GetGenres().Single(g => g.Name ==
            "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "U2"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "How To Dismantle An Atomic Bomb", Genre = GetGenres().Single(g =>
            g.Name == "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "U2"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Pop", Genre = GetGenres().Single(g => g.Name == "Rock"), Price =
            8.99M, Artist = GetArtists().Single(a => a.Name == "U2"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Rattle And Hum", Genre = GetGenres().Single(g => g.Name ==
            "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "U2"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "The Best Of 1980-1990", Genre = GetGenres().Single(g => g.Name ==
            "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "U2"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "War", Genre = GetGenres().Single(g => g.Name == "Rock"), Price =
            8.99M, Artist = GetArtists().Single(a => a.Name == "U2"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Zooropa", Genre = GetGenres().Single(g => g.Name == "Rock"), Price
            = 8.99M, Artist = GetArtists().Single(a => a.Name == "U2"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "UB40 The Best Of - Volume Two [UK]", Genre = GetGenres().Single(g
            => g.Name == "Reggae"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "UB40"), AlbumArtUrl
            = "/Content/Images/placeholder.gif" },
             new Album { Title = "Diver Down", Genre = GetGenres().Single(g => g.Name == "Rock"),
            Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Van Halen"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "The Best Of Van Halen, Vol. I", Genre = GetGenres().Single(g =>
            g.Name == "Rock"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Van Halen"), AlbumArtUrl
            = "/Content/Images/placeholder.gif" },
             new Album { Title = "Van Halen III", Genre = GetGenres().Single(g => g.Name == "Rock"),
            Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Van Halen"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Van Halen", Genre = GetGenres().Single(g => g.Name == "Rock"),
            Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Van Halen"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Axé Bahia 2001", Genre = GetGenres().Single(g => g.Name == "Pop"),
            Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Various GetArtists()"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Sambas De Enredo 2001", Genre = GetGenres().Single(g => g.Name ==
            "Latin"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Various GetArtists()"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Vozes do MPB", Genre = GetGenres().Single(g => g.Name == "Latin"),
            Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Various GetArtists()"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Contraband", Genre = GetGenres().Single(g => g.Name == "Rock"),
            Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Velvet Revolver"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Vinicius De Moraes", Genre = GetGenres().Single(g => g.Name ==
            "Latin"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Vinícius De Moraes"), AlbumArtUrl
            = "/Content/Images/placeholder.gif" },
             new Album { Title = "Bach: Goldberg Variations", Genre = GetGenres().Single(g => g.Name
            == "Classical"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Wilhelm Kempff"),
            AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "Bartok: Violin & Viola Concertos", Genre = GetGenres().Single(g =>
            g.Name == "Classical"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Yehudi Menuhin"),
            AlbumArtUrl = "/Content/Images/placeholder.gif" },
             new Album { Title = "Bach: The Cello Suites", Genre = GetGenres().Single(g => g.Name ==
            "Classical"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Yo-Yo Ma"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" },
             new Album { Title = "Ao Vivo [IMPORT]", Genre = GetGenres().Single(g => g.Name ==
            "Latin"), Price = 8.99M, Artist = GetArtists().Single(a => a.Name == "Zeca Pagodinho"), AlbumArtUrl =
            "/Content/Images/placeholder.gif" }
                         };
           
        }

        public static List<Genre> GetGenres()
        {
            var genres = new List<Genre>
             {
             new Genre { Name = "Rock" },
             new Genre { Name = "Jazz" },
             new Genre { Name = "Metal" },
             new Genre { Name = "Alternative" },
             new Genre { Name = "Disco" },
             new Genre { Name = "Blues" },
             new Genre { Name = "Latin" },
             new Genre { Name = "Reggae" },
             new Genre { Name = "Pop" },
             new Genre { Name = "Classical" }
             };
            return genres;
        }

        public static List<Artist> GetArtists()
        {
            var artists = new List<Artist>
             {
             new Artist { Name = "Aaron Copland & London Symphony Orchestra" },
             new Artist { Name = "Aaron Goldberg" },
             new Artist { Name = "AC/DC" },
             new Artist { Name = "Accept" },
             new Artist { Name = "Adrian Leaper & Doreen de Feis" },
             new Artist { Name = "Aerosmith" },
             new Artist { Name = "Aisha Duo" },
             new Artist { Name = "Alanis Morissette" },
             new Artist { Name = "Alberto Turco & Nova Schola Gregoriana" },
             new Artist { Name = "Alice In Chains" },
             new Artist { Name = "Amy Winehouse" },
             new Artist { Name = "Anita Ward" },
             new Artist { Name = "Antônio Carlos Jobim" },
             new Artist { Name = "Apocalyptica" },
             new Artist { Name = "Audioslave" },
             new Artist { Name = "Barry Wordsworth & BBC Concert Orchestra" },
             new Artist { Name = "Berliner Philharmoniker & Hans Rosbaud" },
             new Artist { Name = "Berliner Philharmoniker & Herbert Von Karajan" },
             new Artist { Name = "Billy Cobham" },
             new Artist { Name = "Black Label Society" },
             new Artist { Name = "Black Sabbath" },
             new Artist { Name = "Boston Symphony Orchestra & Seiji Ozawa" },
             new Artist { Name = "Britten Sinfonia, Ivor Bolton & Lesley Garrett" },
             new Artist { Name = "Bruce Dickinson" },
             new Artist { Name = "Buddy Guy" },
             new Artist { Name = "Caetano Veloso" },
             new Artist { Name = "Cake" },
             new Artist { Name = "Calexico" },
             new Artist { Name = "Cássia Eller" },
             new Artist { Name = "Chic" },
             new Artist { Name = "Chicago Symphony Orchestra & Fritz Reiner" },
             new Artist { Name = "Chico Buarque" },
             new Artist { Name = "Chico Science & Nação Zumbi" },
             new Artist { Name = "Choir Of Westminster Abbey & Simon Preston" },
             new Artist { Name = "Chris Cornell" },
             new Artist { Name = "Christopher O'Riley" },
             new Artist { Name = "Cidade Negra" },
             new Artist { Name = "Cláudio Zoli" },
             new Artist { Name = "Creedence Clearwater Revival" },
             new Artist { Name = "David Coverdale" },
             new Artist { Name = "Deep Purple" },
             new Artist { Name = "Dennis Chambers" },
             new Artist { Name = "Djavan" },
             new Artist { Name = "Donna Summer" },
             new Artist { Name = "Dread Zeppelin" },
             new Artist { Name = "Ed Motta" },
             new Artist { Name = "Edo de Waart & San Francisco Symphony" },
             new Artist { Name = "Elis Regina" },
             new Artist { Name = "English Concert & Trevor Pinnock" },
             new Artist { Name = "Eric Clapton" },
             new Artist { Name = "Eugene Ormandy" },
             new Artist { Name = "Faith No More" },
             new Artist { Name = "Falamansa" },
             new Artist { Name = "Foo Fighters" },
             new Artist { Name = "Frank Zappa & Captain Beefheart" },
             new Artist { Name = "Fretwork" },
             new Artist { Name = "Funk Como Le Gusta" },
             new Artist { Name = "Gerald Moore" },
             new Artist { Name = "Gilberto Gil" },
             new Artist { Name = "Godsmack" },
             new Artist { Name = "Gonzaguinha" },
             new Artist { Name = "Göteborgs Symfoniker & Neeme Järvi" },
             new Artist { Name = "Guns N' Roses" },
             new Artist { Name = "Gustav Mahler" },
             new Artist { Name = "Incognito" },
             new Artist { Name = "Iron Maiden" },
             new Artist { Name = "James Levine" },
             new Artist { Name = "Jamiroquai" },
             new Artist { Name = "Jimi Hendrix" },
             new Artist { Name = "Joe Satriani" },
             new Artist { Name = "Jorge Ben" },
             new Artist { Name = "Jota Quest" },
             new Artist { Name = "Judas Priest" },
             new Artist { Name = "Julian Bream" },
             new Artist { Name = "Kent Nagano and Orchestre de l'Opéra de Lyon" },
             new Artist { Name = "Kiss" },
             new Artist { Name = "Led Zeppelin" },
             new Artist { Name = "Legião Urbana" },
             new Artist { Name = "Lenny Kravitz" },
             new Artist { Name = "Les Arts Florissants & William Christie" },
             new Artist { Name = "London Symphony Orchestra & Sir Charles Mackerras" },
             new Artist { Name = "Luciana Souza/Romero Lubambo" },
             new Artist { Name = "Lulu Santos" },
             new Artist { Name = "Marcos Valle" },
             new Artist { Name = "Marillion" },
             new Artist { Name = "Marisa Monte" },
             new Artist { Name = "Martin Roscoe" },
             new Artist { Name = "Maurizio Pollini" },
             new Artist { Name = "Mela Tenenbaum, Pro Musica Prague & Richard Kapp" },
             new Artist { Name = "Men At Work" },
             new Artist { Name = "Metallica" },
             new Artist { Name = "Michael Tilson Thomas & San Francisco Symphony" },
             new Artist { Name = "Miles Davis" },
             new Artist { Name = "Milton Nascimento" },
             new Artist { Name = "Mötley Crüe" },
             new Artist { Name = "Motörhead" },
             new Artist { Name = "Nash Ensemble" },
             new Artist { Name = "Nicolaus Esterhazy Sinfonia" },
             new Artist { Name = "Nirvana" },
             new Artist { Name = "O Terço" },
             new Artist { Name = "Olodum" },
             new Artist { Name = "Orchestra of The Age of Enlightenment" },
             new Artist { Name = "Os Paralamas Do Sucesso" },
             new Artist { Name = "Ozzy Osbourne" },
             new Artist { Name = "Page & Plant" },
             new Artist { Name = "Paul D'Ianno" },
             new Artist { Name = "Pearl Jam" },
             new Artist { Name = "Pink Floyd" },
             new Artist { Name = "Queen" },
             new Artist { Name = "R.E.M." },
             new Artist { Name = "Raul Seixas" },
             new Artist { Name = "Red Hot Chili Peppers" },
             new Artist { Name = "Roger Norrington, London Classical Players" },
             new Artist { Name = "Royal Philharmonic Orchestra & Sir Thomas Beecham" },
             new Artist { Name = "Rush" },
             new Artist { Name = "Santana" },
             new Artist { Name = "Scholars Baroque Ensemble" },
             new Artist { Name = "Scorpions" },
             new Artist { Name = "Sergei Prokofiev & Yuri Temirkanov" },
             new Artist { Name = "Sir Georg Solti & Wiener Philharmoniker" },
             new Artist { Name = "Skank" },
             new Artist { Name = "Soundgarden" },
             new Artist { Name = "Spyro Gyra" },
             new Artist { Name = "Stevie Ray Vaughan & Double Trouble" },
             new Artist { Name = "Stone Temple Pilots" },
             new Artist { Name = "System Of A Down" },
             new Artist { Name = "Temple of the Dog" },
             new Artist { Name = "Terry Bozzio, Tony Levin & Steve Stevens" },
             new Artist { Name = "The 12 Cellists of The Berlin Philharmonic" },
             new Artist { Name = "The Black Crowes" },
             new Artist { Name = "The Cult" },
             new Artist { Name = "The Doors" },
             new Artist { Name = "The King's Singers" },
             new Artist { Name = "The Police" },
             new Artist { Name = "The Posies" },
             new Artist { Name = "The Rolling Stones" },
             new Artist { Name = "The Who" },
             new Artist { Name = "Tim Maia" },
             new Artist { Name = "Ton Koopman" },
             new Artist { Name = "U2" },
             new Artist { Name = "UB40" },
             new Artist { Name = "Van Halen" },
             new Artist { Name = "Various GetArtists()" },
             new Artist { Name = "Velvet Revolver" },
             new Artist { Name = "Vinícius De Moraes" },
             new Artist { Name = "Wilhelm Kempff" },
             new Artist { Name = "Yehudi Menuhin" },
             new Artist { Name = "Yo-Yo Ma" },
             new Artist { Name = "Zeca Pagodinho" }
             };
             return artists;
        }
    }
}
