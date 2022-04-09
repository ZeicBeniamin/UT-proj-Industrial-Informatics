﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Industrial_Informatics_Project.Scripts.Games.QuizScript
{
    public class Question
    {
        // Index from the database (primary key)
        public int id;

        // Questuin text
        public string question_text;

        // Options for the questions
        public string question_options;

        // Question answer
        public string question_answer;

        // Difficulty of the question
        public int difficulty;

        // Controll variable if the question as been answerd
        public bool is_answerd;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="question_text"></param>
        /// <param name="question_options"></param>
        /// <param name="question_answer"></param>
        /// <param name="difficulty"></param>
        public Question(int id, string question_text, string question_options, string question_answer, int difficulty)
        {
            this.id = id;
            this.question_text = question_text;
            this.question_options = question_options;
            this.question_answer = question_answer;
            this.difficulty = difficulty;
            is_answerd = false;
        }
    }
}
