﻿using System.ComponentModel;

namespace CharacterNamespace
{
    public static class GameCharacter
    {
        #region Основные параметры

        #region Money

        private static int _money = 100;

        public static void OnPropertyChangedMoney(PropertyChangedEventArgs e)
        {
            PropertyChangedMoney?.Invoke(null, e);
        }

        public static void OnPropertyChangedMoney(int propertyNameMoney)
        {
            OnPropertyChangedMoney(new PropertyChangedEventArgs(propertyNameMoney.ToString()));
        }

        /// <summary>
        /// Переменная, хранящая значение денег персонажа
        /// </summary>
        public static int Money
        {
            get { return _money; }
            set
            {
                if (value != _money)
                {
                    _money = value;
                    OnPropertyChangedMoney(_money);
                }
            }
        }

        public static event PropertyChangedEventHandler PropertyChangedMoney;

        #endregion

        #region Food

        private static int _food = 100;

        public static void OnPropertyChangedFood(PropertyChangedEventArgs e)
        {
            PropertyChangedFood?.Invoke(null, e);
        }

        public static void OnPropertyChangedFood(int propertyNameFood)
        {
            OnPropertyChangedFood(new PropertyChangedEventArgs(propertyNameFood.ToString()));
        }

        /// <summary>
        /// Переменная, хранящая значение голода персонажа
        /// </summary>
        public static int Food
        {
            get { return _food; }
            set
            {
                if (value != _food)
                {
                    _food = value;
                    OnPropertyChangedFood(_food);
                }
            }
        }

        public static event PropertyChangedEventHandler PropertyChangedFood;

        #endregion

        #region Mood

        private static int _mood = 100;

        public static void OnPropertyChangedMood(PropertyChangedEventArgs e)
        {
            PropertyChangedMood?.Invoke(null, e);
        }

        public static void OnPropertyChangedMood(int propertyNameMood)
        {
            OnPropertyChangedMood(new PropertyChangedEventArgs(propertyNameMood.ToString()));
        }

        /// <summary>
        /// Переменная, хранящая значение настроения персонажа
        /// </summary>
        public static int Mood
        {
            get { return _money; }
            set
            {
                if (value != _mood)
                {
                    _mood = value;
                    OnPropertyChangedMood(_mood);
                }
            }
        }

        public static event PropertyChangedEventHandler PropertyChangedMood;

        #endregion

        #region Health

        private static int _health = 100;

        public static void OnPropertyChangedHealth(PropertyChangedEventArgs e)
        {
            PropertyChangedHealth?.Invoke(null, e);
        }

        public static void OnPropertyChangedHealth(int propertyNameHealth)
        {
            OnPropertyChangedHealth(new PropertyChangedEventArgs(propertyNameHealth.ToString()));
        }

        /// <summary>
        /// Переменная, хранящая значение здоровья персонажа
        /// </summary>
        public static int Health
        {
            get { return _health; }
            set
            {
                if (value != _health)
                {
                    _health = value;
                    OnPropertyChangedHealth(_health);
                }
            }
        }

        public static event PropertyChangedEventHandler PropertyChangedHealth;

        #endregion

        #endregion

        #region Вспомогательные параметры

        #region PhysicalDevelopment

        private static int _physicalDevelopment = 100;

        public static void OnPropertyChangedPhysicalDevelopment(PropertyChangedEventArgs e)
        {
            PropertyChangedPhysicalDevelopment?.Invoke(null, e);
        }

        public static void OnPropertyChangedPhysicalDevelopment(int propertyNamePhysicalDevelopment)
        {
            OnPropertyChangedPhysicalDevelopment(new PropertyChangedEventArgs(propertyNamePhysicalDevelopment.ToString()));
        }

        /// <summary>
        /// Переменная, хранящая значение физического развития персонажа
        /// </summary>
        public static int PhysicalDevelopment
        {
            get { return _physicalDevelopment; }
            set
            {
                if (value != _physicalDevelopment)
                {
                    _physicalDevelopment = value;
                    OnPropertyChangedPhysicalDevelopment(_physicalDevelopment);
                }
            }
        }

        public static event PropertyChangedEventHandler PropertyChangedPhysicalDevelopment;

        #endregion

        #region Charm

        private static int _charm = 0;

        public static void OnPropertyChangedCharm(PropertyChangedEventArgs e)
        {
            PropertyChangedCharm?.Invoke(null, e);
        }

        public static void OnPropertyChangedCharm(int propertyNameCharm)
        {
            OnPropertyChangedCharm(new PropertyChangedEventArgs(propertyNameCharm.ToString()));
        }

        /// <summary>
        /// Переменная, хранящая значение обаятельности персонажа
        /// </summary>
        public static int Charm
        {
            get { return _charm; }
            set
            {
                if (value != _charm)
                {
                    _charm = value;
                    OnPropertyChangedCharm(_charm);
                }
            }
        }

        public static event PropertyChangedEventHandler PropertyChangedCharm;

        #endregion

        #region Intelligence

        private static int _intelligence = 0;

        public static void OnPropertyChangedIntelligence(PropertyChangedEventArgs e)
        {
            PropertyChangedIntelligence?.Invoke(null, e);
        }

        public static void OnPropertyChangedIntelligence(int propertyNameIntelligence)
        {
            OnPropertyChangedIntelligence(new PropertyChangedEventArgs(propertyNameIntelligence.ToString()));
        }

        /// <summary>
        /// Переменная, хранящая значение интеллекта персонажа
        /// </summary>
        public static int Intelligence
        {
            get { return _intelligence; }
            set
            {
                if (value != _intelligence)
                {
                    _intelligence = value;
                    OnPropertyChangedIntelligence(_intelligence);
                }
            }
        }

        public static event PropertyChangedEventHandler PropertyChangedIntelligence;

        #endregion

        #endregion

        #region Get Set 

        public static void Set(string nameParameter, int valueParameter)
        {
            switch (nameParameter)
            {
                case "Money":

                    Money += valueParameter;

                    break;

                case "Food":

                    Food += valueParameter;

                    break;

                case "Mood":

                    Mood += valueParameter;

                    break;

                case "Health":

                    Health += valueParameter;

                    break;

                case "PhysicalDevelopment":

                    PhysicalDevelopment += valueParameter;

                    break;

                case "Charm":

                    Charm += valueParameter;

                    break;

                case "Intelligence":

                    Intelligence += valueParameter;

                    break;
            }
        }

        public static int Get(string nameParameter)
        {
            switch (nameParameter)
            {
                case "Money":

                    return Money;

                case "Food":

                    return Food;

                case "Mood":

                    return Mood;

                case "Health":

                    return Health;

                case "PhysicalDevelopment":

                    return PhysicalDevelopment;

                case "Charm":

                    return Charm;

                case "Intelligence":

                    return Intelligence;
            }

            return -1;
        }

        #endregion
    }


}