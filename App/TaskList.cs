using System;
using System.Collections.Generic;

namespace App {
    public class TaskList {
        public List<Task> tasks { get; }

        public TaskList(){
            this.tasks = new List<Task>();
        }

        public void AddTask(Task task){
            this.tasks.Add(task);
        }

        public void RemoveTask(Task task){
            this.tasks.Remove(task);
        }

        public Task FindTask(Task task){
            return this.tasks.Find(x => x.description.Equals(task.description));
        }

        public void SetTaskToDone(Task task){
            this.FindTask(task).state = TaskState.DONE;
        }
    }
}