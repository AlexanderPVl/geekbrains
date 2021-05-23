using System;

namespace tasks{

    public delegate TResult Func<out TResult>();

    public class userData{
        public int lesson;
        public userData(){
            lesson = 1;
        }
    }

    class taskExecuter{
        public Func<int>[] lesson1_tasks = {
            lesson1.task1, lesson1.task2, lesson1.task3,
            lesson1.task4, lesson1.task5
        };
        public Func<int>[] lesson2_tasks = {
            lesson2.task1, lesson2.task2, lesson2.task3,
            lesson2.task4, lesson2.task5, lesson2.task6, lesson2.task7
        };

        public void runTask(string[] data, int lesson){
            int n = 0;
            try{
                n = int.Parse(data[1]);
            }
            catch{
                Console.WriteLine("Incorrect \"task\" command arguments");
            }
            switch(lesson){
                case 1:{
                    try{ lesson1_tasks[n - 1](); } catch{}
                    return;
                }
                case 2:{
                    try{ lesson2_tasks[n - 1](); } catch{}
                    return;
                }
                default:{
                    Console.WriteLine("Couldn't run any tasks from the lesson");
                    return;
                }
            }
        }
    }

    class commandProcessor{
        public taskExecuter taskExec = new taskExecuter();
        public userData usrData = new userData();

        public void printHelp(){
            Console.WriteLine("\r\n=======HELP=======\r\n");
            Console.WriteLine("lesson n - select a lesson number n");
            Console.WriteLine("task n - select a task number n from currectly selected lesson");
            Console.WriteLine("quit (q) - quit an application");
            Console.WriteLine("help - print help to console");
            Console.WriteLine("\r\n==================\r\n");
        }

        public enum action { quit, setLesson, runTask, chooseTask, undefined};

        void setLesson(string[] data){
            try{
                usrData.lesson = int.Parse(data[1]);
                Console.WriteLine($"Lesson set to {usrData.lesson}");
            } catch {Console.WriteLine("Failed to set a new lesson");}
        }

        public action processCommand(string input){
            string[] data = input.Split(' ');
            string command = data[0];
            switch(command){
                case "q":{
                    Console.WriteLine("Quit");
                    return action.quit;
                }
                case "quit":{
                    Console.WriteLine("Quit");
                    return action.quit;
                }
                case "lesson":{
                    setLesson(data);
                    return action.setLesson;
                }
                case "task":{
                    taskExec.runTask(data, usrData.lesson);
                    return action.runTask;
                }
                case "help":{
                    printHelp();
                    return action.undefined;
                }
                default:{
                    Console.WriteLine("Unknown command");
                    return action.undefined;
                }
            }
        }
    }
}