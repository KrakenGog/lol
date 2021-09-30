using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class AllNpcDialogs : MonoBehaviour
{
    public static List<Dialog> Informator = new List<Dialog>();
    public static List<Dialog> Lesha = new List<Dialog>();
    public static List<Dialog> Tim = new List<Dialog>();
    public static List<Dialog> GrebenEXE = new List<Dialog>();
    public static List<Dialog> Gleb = new List<Dialog>();
    public static List<Dialog> Evgeni = new List<Dialog>();

    private void Awake()
    {
        DialogIntit();
    }
    private void DialogIntit()
    {
        Informator.Add(
            new Dialog(0,
                new DialogAct[]
                {
                    new DialogAct("Привет",new Answer[]{new Answer("Привет", null,1),new Answer("Пока",null,-1)}),
                      new DialogAct("Можешь спросить меня о том что тебя интересует",new Answer[]{new Answer("Как Гребень пришёл к власти?",null,2),new Answer("Почему везде плакаты Гребня?",null,3),new Answer("Пока",null,-1)}),
                        new DialogAct(".........Это..........мне пора, увидимся...",new Answer[]{new Answer("Хм... Странно",null,-1)}),
                        new DialogAct("Дабы создать олимпиадную атмосферу в лицее. Может ещё хочешь что-нибудь узнать?",new Answer[]{new Answer("Ага",null,1),new Answer("Пока",null,-1)}),
                    

                }
                )
        );
        Lesha.Add(
            new Dialog(0,
            new DialogAct[] {

                 new DialogAct("Хочешь информацию о Диме?",new Answer[]{CreateAnswer("Довай, мне очень интересно)",null,1),CreateAnswer("Конечно",null,1),CreateAnswer("Естественно",null,1)}),
                 new DialogAct("Дима лох",new Answer[]{CreateAnswer("Вааауууу, а я не знааал",null,-1),CreateAnswer("Это общеизвесный факт",null,-1)}),
            }
            )
            );
        Tim.Add(
            new Dialog(0,
            new DialogAct[] {

                 new DialogAct("Тяжело жить в Росии",new Answer[]{CreateAnswer("Солидарен",null,1),CreateAnswer("Полностью не согласен",null,9)}),
                    new DialogAct("Тяжело жить в Белоруси",new Answer[]{CreateAnswer("Ага",null,2),CreateAnswer("Нет",null,3)}),
                        new DialogAct("Го чесскомить",new Answer[]{CreateAnswer("Го",null,-1),CreateAnswer("Нехочу",null,-1)}),
                        new DialogAct("Пруфани",new Answer[]{CreateAnswer("Ладно тяжело, признаю",null,-1),CreateAnswer("Посмотри вокруг, небо, земля....Разве это не прикрасно? ",null,4)}),
                           new DialogAct("Умно сказано",new Answer[]{CreateAnswer("Я умею умно говорить",null,5),CreateAnswer("Не может быть, я всегда говорю как идиот",null,8)}),
                              new DialogAct("Оно видно. Ладно я пойду",new Answer[]{CreateAnswer("Пока",null,-1),CreateAnswer("Стооой",null,6)}),
                                 new DialogAct("Что ещё?",new Answer[]{CreateAnswer("Я хотел тебя спросить на счёт тайной комнаты",null,7),CreateAnswer("Не ничего, пока",null,-1)}),
                                 new DialogAct("Так уж и быть, расскажу. Ходят легенды что после того как к власти в лицее пришёл Гребень, он приказал построить тайную комнату по которой он сможет сбежать. По легенде вход в неё в его же кабинете, а где выход никто не знает...",new Answer[]{CreateAnswer("Вот это да",null,-1)}),
                              new DialogAct("Так и есть",new Answer[]{CreateAnswer("Обидно",null,-1),CreateAnswer("Пофиг",null,-1)}),
                    new DialogAct("Где пруфы?",new Answer[]{CreateAnswer("В жопе",null,10),CreateAnswer("На луне",null,10)}),
                       new DialogAct("Ну ты юморист",new Answer[]{CreateAnswer("Получше тебя",null,11),CreateAnswer("Ладно я пойду",null,-1)}),
                          new DialogAct("Ты нарываешся?",new Answer[]{CreateAnswer("Это ты нарываешся",null,12),CreateAnswer("Нет",null,13)}),
                             new DialogAct("Иди в жопу",new Answer[]{CreateAnswer("Взаимно",null,-1)}),
                             new DialogAct("Ну смотри",new Answer[]{CreateAnswer("Хорошо, буду следить за словами",null,-1)}),
            }
            )
            );
        GrebenEXE.Add(
           new Dialog(0,
           new DialogAct[] {

                 new DialogAct("Сколько вариантов олимпиады Барсик ты решил?",new Answer[]{CreateAnswer("Я и не зарегистрировался",null,1),CreateAnswer("Все",null,3),CreateAnswer("Что вы пристали с этими олимпиадами?",null,6)}),
                    new DialogAct("2 загод и иди гуляй",new Answer[]{CreateAnswer("Идите в жопу",null,2),CreateAnswer("Нееееееееееееет",null,-1)}),
                       new DialogAct("Вон из лицея молекула обделённая",new Answer[]{CreateAnswer("Идите на ***",null,-1)}),
                    new DialogAct("Молодец, довай сюда решения, я хочу нобелевскую премию",new Answer[]{CreateAnswer("Ну ладно",null,4),CreateAnswer("Они мои",null,5)}),
                       new DialogAct("Ебать спасибо нахуй",new Answer[]{CreateAnswer("Всегда пожалуйста",null,-1)}),
                       new DialogAct("Иди сюда чмо ебаное я тебя на кусочки разорву",new Answer[]{CreateAnswer("Спасити",null,-1)}),
                    new DialogAct("Я не понял, нука встал.        Сколько степеней свободы у молекулы из 3 атомов?",new Answer[]{CreateAnswer("Что такое степени свабоды",null,1),CreateAnswer("3",null,1),CreateAnswer("6",null,7)}),
                       new DialogAct("Ладно живи",new Answer[]{CreateAnswer("Сссссспасссибо",null,-1)}),
                       
           }
           )
           );
        Gleb.Add(
           new Dialog(0,
           new DialogAct[] {

                 new DialogAct("Бля, моя 3060 лёшины игры не тянет. Надо ноут апгрэйдить",new Answer[]{CreateAnswer("Привет",null,1)}),
                    new DialogAct("О привет, даш денег на апгрейт пк?",new Answer[]{CreateAnswer("Сколько надо?",null,2),CreateAnswer("Нет конечно",null,5)}),
                    new DialogAct("Тысяч 30, не более",new Answer[]{CreateAnswer("Ты ухуел?",null,3),CreateAnswer("Конучно дам, что за пустяк",null,4)}),
                       new DialogAct("Бро тебе что жалко?",new Answer[]{CreateAnswer("Иди в жопу",null,-1),CreateAnswer("Ладно уговорил",null,4)}),
                          new DialogAct("Вот и славно",new Answer[]{CreateAnswer("Пока",null,-1)}),
                    new DialogAct("Ну ты и овощь, пойду подрачу на Unreal Engine",new Answer[]{CreateAnswer("Удачи",null,-1)}),

           }
           )
           );
        Evgeni.Add(
          new Dialog(0,
          new DialogAct[] {

                 new DialogAct("Браааааавл стаааааарс, я поююююю про неггггооооо, потому что жить не могу без негггоооооооо",new Answer[]{CreateAnswer("Кхм кхм",null,1)}),
                    new DialogAct("Ой не заметил",new Answer[]{CreateAnswer("Продолжай, я не возражаю",null,2),CreateAnswer("Как дела?",null,5)}),
                       new DialogAct("Щас дух переведу            Каждый день захожууууу, ужас на врагов навожуууууу, ужинать не хожууууууу, ибо срать так хочууууууу",new Answer[]{CreateAnswer("*Оплодисменты*",null,3),CreateAnswer("Что-то фигня какаета",null,4)}),
                          new DialogAct("Не стоит, я парень скромный",new Answer[]{CreateAnswer("Ты заслужил. Ну я пойду",null,-1)}),
                          new DialogAct("Всё я обиделся",new Answer[]{CreateAnswer("Ну и ладно",null,-1)}),
                       new DialogAct("Норм, вчера нового перса выбил. Имба вообще",new Answer[]{CreateAnswer("Ладно, пока",null,-1)}),

          }
          )
          );
    }
    private Answer CreateAnswer(string answer,string con,int index)
    {
        return new Answer(answer, con, index);
    }
   
}
