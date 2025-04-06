using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;


public class Behaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Hello World");
        //int Level = 20;
        //float Strength = 15.23f;
        //string UserName = "나힐순";
        //bool IsAlive = true;

        //Debug.Log("Level: " + Level);
        //Debug.Log("Strength: " + Strength);
        //Debug.Log("UserName: " + UserName);
        //Debug.Log("IsAlive: " + IsAlive);

        //string[] name = {"나힐순", "케인인님", "나힐순"};
        //int[ ] cosmic = new int[3];
        //cosmic[0] = 99;
        //cosmic[1] = 99;
        //cosmic[2] = 99; 

        //Debug.Log("name[0]: " + name[0]);
        //Debug.Log("name[1]: " + name[1]);
        //Debug.Log("name[2]: " + name[2]);

        //List<string> speicalitem = new List<string>();
        //speicalitem.Add("기억의조각");
        //speicalitem.Add("후회의조각");
        //Debug.Log(speicalitem[0]);
        //Debug.Log(speicalitem[1]);

        //int exp = 2000;

        //exp = exp + 1000;
        //if (exp >= 2000)
        //{
        //    Debug.Log("강화 성공");
        //}
        //else
        //{
        //    Debug.Log("강화 실패");
        //}
        //Strength = exp * 0.23f;
        //Debug.Log("Strength: " + Strength);
        //bool isFullLevel = false;
        //int Level = 20;
        //int FullLevel = 50;
        //isFullLevel = Level == FullLevel;
        //Debug.Log("isFullLevel: " + isFullLevel);

        // && : and
        // || : or
        // ! : not
        // == : equal
        // != : not equal
        // > : greater than
        // < : less than
        // bool value ? A : B : if bool is true, A else B

        // 키워드 : int, float, string, bool, List, new

        // 조건문 : if (조건) { 실행문 }, else if (조건) { 실행문 }, else { 실행문 }
        // 조건문 : switch (변수) { case 값1: 실행문; break; case 값2: 실행문; break; default: 실행문; break; }
        //int a = 2;
        //bool bad = true;
        //string condition = bad ? "나쁨" : "좋음";

        //var ItemList = new List<string>();
        //ItemList.Add("검");
        //ItemList.Add("방패");
        //ItemList.Add("투구");

        //if (condition == "나쁨")
        //{
        //    Debug.Log("상태가 좋지 않습니다.");
        //}
        //else
        //{
        //    Debug.Log("상태가 좋습니다.");
        //}

        //if (bad && ItemList[0] == "검")
        //{
        //    ItemList.RemoveAt(0);
        //    Debug.Log("검으로 반격 하세요!");
        //}
        //else if (bad || ItemList[1] == "방패")
        //{
        //    ItemList.RemoveAt(1);
        //    Debug.Log("방패로 막아주세요!");
        //}
        //else if (bad || ItemList[2] == "투구")
        //{
        //    ItemList.RemoveAt(2);
        //    Debug.Log("투구를 입으세요!");
        //}

        //string[] monster = { "슬라임", "고블린", "드래곤" };


        //switch (monster[a])
        //{
        //    case "슬라임":
        //        Debug.Log("소형몬스터 출현!");
        //        break;
        //    case "고블린":
        //        Debug.Log("중형몬스터 출현!");
        //        break;
        //    case "드래곤":
        //        Debug.Log("대형몬스터 출현!");
        //        break;
        //    default:
        //        Debug.Log("??? 출현!");
        //        break;
        //}


        // 반복문 : for (int i = 0; i < 10; i++) { 실행문 }

        //int lap = 2;
        //while (lap > 0)
        //{
        //    lap--;
        //    if (lap > 0)
        //    {
        //        Debug.Log("다음 라운드로 이동합니다.");
        //    }
        //    else
        //    {
        //        Debug.Log($"라운드 종료");
        //    }

        //    int Hp = 100;


        //    while (Hp > 0)
        //    {
        //        Hp -= 10;
        //        if (Hp > 0)
        //        {
        //            Debug.Log($"Hp : {Hp}");
        //        }
        //        else
        //        {
        //            Debug.Log("사망했습니다.");

        //        }
        //        if (Hp == 10)
        //        {
        //            Debug.Log("해독합니당");
        //            break;
        //        }
        //    }

        //    for (int count = 0; count < 20; count += 5)
        //    {
        //        Hp += 10;
        //        Debug.Log($"치료중입니다,,,{Hp}");

        //    }

        //    string[] monsters = { "C급 몬스터", "A급 몬스터", "S급 몬스터" };

        //    foreach(string monster in monsters)
        //    {
        //        Debug.Log("이 구역의 몬스터는.. : " + monster);
        //    }

            // 함수(메소드) : int Heal (int currenthealth) {currenthealth +=20; \n return currenthealth;}
