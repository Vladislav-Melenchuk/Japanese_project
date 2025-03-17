using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public enum DifficultyLevel
    {
        Easy,
        Medium,
        Hard
    }

    public class Level
    {
        public string Name { get; set; }
        public DifficultyLevel Difficulty { get; set; }
        public int GridSize { get; set; }
        public bool[,] Solution { get; set; }
        public List<int[]> RowHints { get; set; }
        public List<int[]> ColHints { get; set; }
    }

    public static class LevelRepository
    {
        public static List<Level> Levels { get; private set; } = new List<Level>();

        static LevelRepository()
        {
            AddEasyLevels();
            AddMediumLevels();
            AddHardLevels();
        }

        private static void AddEasyLevels()
        {
            //Рисунок -  Медуза
            Levels.Add(new Level
            {
                Name = "Легкий рівень 1",
                Difficulty = DifficultyLevel.Easy,
                GridSize = 6,
                Solution = new bool[6, 6]
                {
                    { false, true, true, false, false, false },
                    { false, false, true, true, false, false},
                    { false, true, true, true, true, false},
                    { true, false, true, true, true , true},
                    { false, true, false, true, false, true },
                    { false, false, true, false, false, false}
                },
                RowHints = new List<int[]> { new int[] {2}, new int[] {2}, new int[] { 4 }, new int[] { 1, 4 }, new int[] { 1, 1, 1 }, new int[] { 1 } },
                ColHints = new List<int[]> { new int[] { 1 }, new int[] { 1, 1, 1 }, new int[] { 4, 1 }, new int[] { 4 }, new int[] { 2 }, new int[] { 2 } }
            });

            //Кіт
            Levels.Add(new Level
            {
                Name = "Легкий рівень 2 ",
                Difficulty = DifficultyLevel.Easy,
                GridSize = 6,
                Solution = new bool[6, 6]
            {
                    { false, true, false, false, true, false },
                    { true, false, true, true, false, true },
                    { false, true, true, true, true, false },
                    { true, false, false, false, false, true },
                    { false, true, false, false, true, false },
                    { false, false, true, true, false, false }
            },
                RowHints = new List<int[]> { new int[] { 1, 1 }, new int[] { 1, 2, 1 }, new int[] { 4 }, new int[] { 1, 1 }, new int[] { 1, 1 }, new int[] { 2 } },
                ColHints = new List<int[]> { new int[] { 1, 1 }, new int[] { 1, 1, 1 }, new int[] { 2, 1 }, new int[] { 2, 1 }, new int[] { 1, 1, 1 }, new int[] { 1, 1 } }
            });

            //Зірка 
            Levels.Add(new Level
            {
                Name = "Легкий рівень 3",
                Difficulty = DifficultyLevel.Easy,
                GridSize = 6,
                Solution = new bool[6, 6]
                {
            { false, false, true, true, false, false },
            { false, true, true, true, true, false },
            { true, true, true, true, true, true },
            { true, true, true, true, true, true },
            { false, true, true, true, true, false },
            { false, false, true, true, false, false }
                },
                RowHints = new List<int[]>
        {
            new int[] { 2 }, new int[] { 4 }, new int[] { 5 },
            new int[] { 5 }, new int[] { 4 }, new int[] { 2}
        },
                ColHints = new List<int[]>
        {
            new int[] { 2 }, new int[] { 4 }, new int[] { 5 },
            new int[] { 5}, new int[] { 4 }, new int[] { 2}
        }
            });

        }

        private static void AddMediumLevels()
        {
            //Летюча миша
            Levels.Add(new Level
            {
                Name = "Середній рівень 1",
                Difficulty = DifficultyLevel.Medium,
                GridSize = 8,
                Solution = new bool[8, 8]
     {
        { false, false, true, false, false, true, false, false },
        { false, true, true, true, true, true, true, false },
        { true, true, false, true, true, false, true, true },
        { true, false, true, false, false, true, false, true },
        { true, false, true, true, true, true, false, true },
        { false, true, false, false, false, false, true, false },
        { false, false, true, false, false, true, false, false },
        { false, false, false, true, true, false, false, false }
     },
                RowHints = new List<int[]>
    {
        new int[] { 1, 1 }, new int[] { 6 }, new int[] { 2, 2 }, new int[] { 1, 1, 1, 1 },
        new int[] { 1, 4, 1 }, new int[] { 1, 1 }, new int[] { 1, 1 }, new int[] { 2 }
    },
                ColHints = new List<int[]>
    {
        new int[] { 1 }, new int[] { 2 }, new int[] { 1, 2 }, new int[] { 6 },
        new int[] { 6 }, new int[] { 1, 2 }, new int[] { 2 }, new int[] { 1 }
    }
            });

            //Циліндр 
            Levels.Add(new Level
            {
                Name = "Середній рівень 2",
                Difficulty = DifficultyLevel.Medium,
                GridSize = 8,
                Solution = new bool[8, 8]
                {
                    { false, false, false, true, true, false, false, false },
                    { false, false, true, true, true, true, false, false },
                    { false, true, true, true, true, true, true, false },
                    { true, true, true, true, true, true, true, true },
                    { false, false, false, true, true, false, false, false },
                    { false, false, false, true, true, false, false, false },
                    { false, false, false, true, true, false, false, false },
                    { false, false, false, true, true, false, false, false }
                },
                RowHints = new List<int[]>
                {
                    new int[] { 2 }, new int[] { 4 }, new int[] { 6 },
                    new int[] { 8 }, new int[] { 2 }, new int[] { 2 },
                    new int[] { 2 }, new int[] { 2 }
                },
                ColHints = new List<int[]>
                {
                    new int[] { 1 }, new int[] { 2 }, new int[] { 3 },
                    new int[] { 8 }, new int[] { 3 }, new int[] { 2 },
                    new int[] { 1 }, new int[] { 1 }
                }
            });


            //Велосипед 
            Levels.Add(new Level
            {
                Name = "Середній рівень 3",
                Difficulty = DifficultyLevel.Medium,
                GridSize = 8,
                Solution = new bool[8, 8]
       {
        { false, false, true, false, false, false, true, false },
        { false, true, false, true, false, true, false, false },
        { true, false, false, true, false, false, true, false },
        { true, false, true, true, true, true, false, true },
        { false, true, false, false, false, false, true, false },
        { false, false, true, false, false, true, false, false },
        { false, false, false, true, true, false, false, false },
        { false, false, false, true, true, false, false, false }
       },
                RowHints = new List<int[]>
    {
        new int[] { 1, 1 }, new int[] { 1, 1, 1 }, new int[] { 1, 1, 1 },
        new int[] { 1, 4, 1 }, new int[] { 1, 1 }, new int[] { 1, 1 },
        new int[] { 2 }, new int[] { 2 }
    },
                ColHints = new List<int[]>
    {
        new int[] { 1 }, new int[] { 1 }, new int[] { 3 },
        new int[] { 6 }, new int[] { 3 }, new int[] { 1 },
        new int[] { 1 }, new int[] { 1 }
    }
            });






        }

        private static void AddHardLevels()
        {
            // Рисунок утка
            Levels.Add(new Level
            {
                Name = "Важкий рівень 1",
                Difficulty = DifficultyLevel.Hard,
                GridSize = 10,
                Solution = new bool[10, 10]
                {
                    { false, true, true,true, false, false, false, false, false, false },
                    { false, true, false, true, true, false, false, false, false, false },
                    { true, true, true, true, true, false, false, false, false, false },
                    { false, false, true, true, false, false, false, false, false, false },
                    { false, true, true, false, false, false, false, true, true, false },
                    { true, true, true, true, true, true, true, true, true, true },
                    { true, true, true, true, true, true, true, true, true, false },
                    { true, true, false, false, true, true, true, true, false, false },
                    { true, true, true, true, false, true, true, false, false, false },
                    { false, true, true, true, true, true, false, false, false, false }
                },
                RowHints = new List<int[]> { new int[] { 3 }, new int[] { 1, 2 }, new int[] { 5 }, new int[] { 2 }, new int[] { 2, 2 }, new int[] { 10 }, new int[] { 9 }, new int[] { 2, 4 }, new int[] { 4, 2 }, new int[] { 5 } },
                ColHints = new List<int[]> { new int[] { 1, 4 }, new int[] { 3, 6 }, new int[] { 1, 5, 2 }, new int[] { 4, 2, 2 }, new int[] { 2, 3, 1 }, new int[] { 5 }, new int[] { 4 }, new int[] { 4 }, new int[] { 3 }, new int[] { 1 } }
            });

            //Черепаха
            Levels.Add(new Level
            {
                Name = "Важкий рівень 2",
                Difficulty = DifficultyLevel.Hard,
                GridSize = 10,
                Solution = new bool[10, 10]
     {
        { false, false, false, true, true, true, false, false, false, false },
        { false, true, true, true, true, true, true, true, false, false },
        { true, true, false, true, true, true, false, true, true, false },
        { false, true, true, true, true, true, true, true, false, false },
        { false, false, false, true, true, true, false, false, false, false },
        { false, false, true, true, true, true, true, true, false, false },
        { false, true, false, true, false, false, true, false, true, false },
        { true, false, true, false, false, false, false, true, false, true },
        { false, false, true, false, false, false, false, true, false, false },
        { false, false, false, true, true, true, true, false, false, false }
     },
                RowHints = new List<int[]>
    {
        new int[] { 3 }, new int[] { 6 }, new int[] { 2, 3, 2 }, new int[] { 6 },
        new int[] { 3 }, new int[] { 6 }, new int[] { 1, 1, 1 }, new int[] { 1, 1, 1 },
        new int[] { 1, 1 }, new int[] { 4 }
    },
                ColHints = new List<int[]>
    {
        new int[] { 1 }, new int[] { 2 }, new int[] { 2, 2 }, new int[] { 6 },
        new int[] { 6 }, new int[] { 6 }, new int[] { 2, 2 }, new int[] { 2 },
        new int[] { 1 }, new int[] { 1 }
    }
            });

            // 3. Краб 
            Levels.Add(new Level
            {
                Name = "Важкий рівень 3",
                Difficulty = DifficultyLevel.Hard,
                GridSize = 10,
                Solution = new bool[10, 10]
                {
                    { false, false, true, true, true, true, true, true, false, false },
                    { false, true, true, false, false, false, false, true, true, false },
                    { true, true, true, true, true, true, true, true, true, true },
                    { false, false, true, false, true, false, true, false, false, false },
                    { false, false, true, false, true, false, true, false, false, false },
                    { false, false, true, true, true, true, true, false, false, false },
                    { false, false, true, false, false, false, true, false, false, false },
                    { false, false, true, false, false, false, true, false, false, false },
                    { false, false, true, false, false, false, true, false, false, false },
                    { false, false, true, false, false, false, true, false, false, false }
                },
                RowHints = new List<int[]>
                {
                    new int[] { 6 }, new int[] { 2, 2 }, new int[] { 10 },
                    new int[] { 1, 1, 1 }, new int[] { 1, 1, 1 }, new int[] { 5 },
                    new int[] { 1, 1 }, new int[] { 1, 1 }, new int[] { 1, 1 }, new int[] { 1, 1 }
                },
                ColHints = new List<int[]>
                {
                    new int[] { 1, 1 }, new int[] { 1, 1 }, new int[] { 10 },
                    new int[] { 1, 1 }, new int[] { 1, 1 }, new int[] { 1, 1 },
                    new int[] { 5 }, new int[] { 1, 1 }, new int[] { 1, 1 }, new int[] { 1, 1 }
                }
            });



        }

        public static Level GetLevel(string name)
        {
            return Levels.FirstOrDefault(level => level.Name == name);
        }
    }
}
