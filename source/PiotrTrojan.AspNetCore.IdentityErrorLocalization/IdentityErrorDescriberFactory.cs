﻿using System;
using Microsoft.AspNetCore.Identity;
using PiotrTrojan.AspNetCore.IdentityErrorLocalization.de_DE;
using PiotrTrojan.AspNetCore.IdentityErrorLocalization.es_ES;
using PiotrTrojan.AspNetCore.IdentityErrorLocalization.fa_IR;
using PiotrTrojan.AspNetCore.IdentityErrorLocalization.fr_FR;
using PiotrTrojan.AspNetCore.IdentityErrorLocalization.pl_PL;
using PiotrTrojan.AspNetCore.IdentityErrorLocalization.pt_PT;
using PiotrTrojan.AspNetCore.IdentityErrorLocalization.ru_RU;
using PiotrTrojan.AspNetCore.IdentityErrorLocalization.sv_SE;
using PiotrTrojan.AspNetCore.IdentityErrorLocalization.tr_TR;
using PiotrTrojan.AspNetCore.IdentityErrorLocalization.uk_UA;

namespace IdentityErrorLocalization.Multilang
{
    public class IdentityErrorDescriberFactory
    {
        private readonly string culture;

        public IdentityErrorDescriberFactory(string culture)
        {
            this.culture = culture ?? "";
        }

        public IdentityErrorDescriber GetDescriber()
        {
            return culture.ToLower() switch
            {
                "" => new IdentityErrorDescriber(),
                "en" => new IdentityErrorDescriber(),
                "de" => new GermanIdentityErrorDescriber(),
                "es" => new SpanishIdentityErrorDescriber(),
                "fa" => new PersianIdentityErrorDescriber(),
                "fr" => new FrenchIdentityErrorDescriber(),
                "pl" => new PolishIdentityErrorDescriber(),
                "pt" => new PortugueseIdentityErrorDescriber(),
                "ru" => new RussianIdentityErrorDescriber(),
                "sv" => new SwedishIdentityErrorDescriber(),
                "tr" => new TurkishIdentityErrorDescriber(),
                "uk" => new UkrainianIdentityErrorDescriber(),
                _ => throw new ArgumentException($"Unsupported culture: {culture}.")
            };
        }
    }
}