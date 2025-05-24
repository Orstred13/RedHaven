using RedHaven.Enums.CharacterEnums;
using RedHaven.Enums.SkillEnums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedHaven.Models
{
    internal class CharacterModel
    {
        // Общая информация
        public string Name { get; set; }              // Настоящее имя персонажа
        public string Handle { get; set; }            // Псевдоним (уличное имя)
        public CharacterRole Role { get; set; }       // Роль (класс персонажа: Solo, Netrunner и т.д.)
        public int Age { get; set; }                  // Возраст
        public string Gender { get; set; }            // Пол
        public string CulturalOrigins { get; set; }   // Культурное происхождение
        public string Appearance { get; set; }        // Внешность (особенности)
        public string Backstory { get; set; }         // История персонажа
        public string Motivations { get; set; }       // Мотивации (что движет персонажем)

        // Характеристики (STATS)
        public int Intelligence { get; set; }         // INT — интеллект
        public int Reflexes { get; set; }             // REF — рефлексы
        public int Dexterity { get; set; }            // DEX — ловкость
        public int Tech { get; set; }                 // TECH — технические навыки
        public int Cool { get; set; }                 // COOL — харизма
        public int Willpower { get; set; }            // WILL — сила воли
        public int MaxLuck { get; set; }              // LUCK — максимальная удача
        public int CurrentLuck { get; set; }          // LUCK — текущая удача
        public int Movement { get; set; }             // MOVE — скорость перемещения
        public int Body { get; set; }                 // BODY — телосложение
        public int MaxEmpathy { get; set; }           // EMP — максимальная эмпатия
        public int CurrentEmpathy { get; set; }       // EMP — текущая эмпатия

        // Навыки
        public List<SkillModel> Skills { get; set; } = new(); // Список умений и навыков

        // Здоровье и боевые параметры
        public int MaxHP { get; set; }                // Максимальное количество ХП
        public int CurrentHP { get; set; }            // Текущее количество ХП
        public int DeathSave { get; set; }            // Порог проверки на смерть
        public int SeriouslyWoundedThreshold { get; set; } // Порог серьезных ранений (обычно половина MaxHP)

        // Киберимпланты и человечность
        public List<Cyberware> Cyberware { get; set; } = new(); // Список киберимплантов
        public int Humanity { get; set; }             // Уровень человечности (EMP * 10)
        public int HumanityLoss { get; set; }         // Суммарная потеря человечности от имплантов

        // Экипировка
        public List<Weapon> Weapons { get; set; } = new(); // Оружие, находящееся у персонажа
        public List<Armor> Armor { get; set; } = new();    // Защитная броня

        // Специальные способности
        public RoleAbility RoleAbility { get; set; }  // Уникальная способность роли (например, Combat Awareness)

        // Финансы
        public int Eddies { get; set; }               // Текущие деньги персонажа (валюта в игре)

        // Прочее
        public string Notes { get; set; }

        public CharacterModel CreateNewCharacter()
        {
            return new CharacterModel
            {
                Skills = GenerateBaseSkills()
            };
        }

        private List<SkillModel> GenerateBaseSkills()
        {
            return Enum.GetValues(typeof(SkillName))
            .Cast<SkillName>()
            .Select(name => new SkillModel
            {
                Name = name,
                Stat = SkillStatMap[name], // Словарь соответствий
                Level = 0
            })
            .ToList();
        }

        private readonly Dictionary<SkillName, StatType> SkillStatMap = new()
        {
            // INT
            { SkillName.ConcealalObject, StatType.INT },
            { SkillName.LipReading, StatType.INT },
            { SkillName.Perception, StatType.INT },
            { SkillName.Tracking, StatType.INT },
            { SkillName.Accounting, StatType.INT },
            { SkillName.AnimalHandling, StatType.INT },
            { SkillName.Bureaucracy, StatType.INT },
            { SkillName.Business, StatType.INT },
            { SkillName.Composition, StatType.INT },
            { SkillName.Criminology, StatType.INT },
            { SkillName.Cryptography, StatType.INT },
            { SkillName.Deduction, StatType.INT },
            { SkillName.Education, StatType.INT },
            { SkillName.Gamble, StatType.INT },
            { SkillName.Language, StatType.INT },
            { SkillName.LibrarySearch, StatType.INT },
            { SkillName.LocalExpert, StatType.INT },
            { SkillName.Science, StatType.INT },
            { SkillName.Tactics, StatType.INT },
            { SkillName.WildernessSurvival, StatType.INT },

            // REF
            { SkillName.DriveLandVehicle, StatType.REF },
            { SkillName.PilotAirVehicle, StatType.REF },
            { SkillName.PilotSeaVehicle, StatType.REF },
            { SkillName.Riding, StatType.REF },
            { SkillName.Archery, StatType.REF },
            { SkillName.Autofire, StatType.REF },
            { SkillName.Handgun, StatType.REF },
            { SkillName.HeavyWeapon, StatType.REF },
            { SkillName.ShoulderArms, StatType.REF },

            // DEX
            { SkillName.Athletics, StatType.DEX },
            { SkillName.Contortionist, StatType.DEX },
            { SkillName.Dance, StatType.DEX },
            { SkillName.Stealth, StatType.DEX },
            { SkillName.Brawling, StatType.DEX },
            { SkillName.Evasion, StatType.DEX },
            { SkillName.MartialArts, StatType.DEX },
            { SkillName.MeleeWeapon, StatType.DEX },

            // TECH
            { SkillName.PlayInstrument, StatType.TECH },
            { SkillName.AirVehicleTech, StatType.TECH },
            { SkillName.BasicTech, StatType.TECH },
            { SkillName.Cybertech, StatType.TECH },
            { SkillName.Demolitions, StatType.TECH },
            { SkillName.ElectronicsSecurityTech, StatType.TECH },
            { SkillName.FirstAid, StatType.TECH },
            { SkillName.Forgery, StatType.TECH },
            { SkillName.LandVehicleTech, StatType.TECH },
            { SkillName.PaintDrawSculpt, StatType.TECH },
            { SkillName.Paramedic, StatType.TECH },
            { SkillName.PhotographyFilm, StatType.TECH },
            { SkillName.PickLock, StatType.TECH },
            { SkillName.PickPocket, StatType.TECH },
            { SkillName.SeaVehicleTech, StatType.TECH },
            { SkillName.Weaponstech, StatType.TECH },

            // COOL
            { SkillName.Acting, StatType.COOL },
            { SkillName.Bribery, StatType.COOL },
            { SkillName.Interrogation, StatType.COOL },
            { SkillName.Persuasion, StatType.COOL },
            { SkillName.PersonalGrooming, StatType.COOL },
            { SkillName.Streetwise, StatType.COOL },
            { SkillName.Trading, StatType.COOL },
            { SkillName.WardrobeStyle, StatType.COOL },

            // WILL
            { SkillName.Endurance, StatType.WILL },
            { SkillName.ResistTortureDrugs, StatType.WILL },
            { SkillName.Concentration, StatType.WILL },

            // EMP
            { SkillName.Conversation, StatType.EMP },
            { SkillName.HumanPerception, StatType.EMP },
        };
    }
}
