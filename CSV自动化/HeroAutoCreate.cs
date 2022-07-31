/************************************************************************
该文件是通过自动生成的，禁止手动修改
作者：yin
日期：2022/7/20 9:06:31
*************************************************************************/
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using UnityEditor;
using System.IO;
using System.Collections.Generic;

public class HeroAutoCreate
{
	public int heroId;
	public string name;
	public string _note;
	public int rare;
	public int type;
	public float advance_rate;
	public int attack;
	public bool isOpen;
}
public class JsonToCsvHeroAutoCreate
{
	public List<HeroAutoCreate> HeroAutoCreate_list = new List<HeroAutoCreate>();
	public void JsonToCsvOpen()
	{
		string json = "Assets/Hero.csv";
		string[] fileStr = File.ReadAllLines(json);
		for (int i = 2; i < fileStr.Length; i++){
			string[] list_open = fileStr[i].Split(',');
			HeroAutoCreate jsons = new HeroAutoCreate();
			jsons.heroId = int.Parse(list_open[0]);
			jsons.name = list_open[1];
			jsons._note = list_open[2];
			jsons.rare = int.Parse(list_open[3]);
			jsons.type = int.Parse(list_open[4]);
			jsons.advance_rate = float.Parse(list_open[5]);
			jsons.attack = int.Parse(list_open[6]);
			HeroAutoCreate_list.Add(jsons);}
	}
	public List<HeroAutoCreate> data(){
		if(HeroAutoCreate_list.Count== 0)  
		JsonToCsvOpen();
	return HeroAutoCreate_list;}

	public void AddData(HeroAutoCreate data){
		HeroAutoCreate_list.Add(data);
	}

	public bool TryDeleteDataByIndex(int index){
		if(HeroAutoCreate_list[index]!=null)  {
		HeroAutoCreate_list.RemoveAt(index);
	return true;}
	return false;}
	public void TryChangeDataByIndex(int index,HeroAutoCreate data){
		if(HeroAutoCreate_list[index]!=null)  {
		HeroAutoCreate_list[index]=data;
	}
	}
	public HeroAutoCreate TryGetDataByIndex(int index){
		if(HeroAutoCreate_list[index]!=null)  
		return HeroAutoCreate_list[index];
	return null;}
	public HeroAutoCreate TryGetDataByValue( HeroAutoCreate data){
	foreach (var item in HeroAutoCreate_list){ 
		if (item==data)
		return item;
	}
	return null;}
}
