using System;

namespace App {
    public class Task {
        public string description { get; set; }
        public DateTime date { get; set; }
        public TaskState state { get; set; }

        public Task(string description, DateTime date, TaskState state){
            this.description = description;
            this.date = date;
            this.state = state;
        }

    }
}