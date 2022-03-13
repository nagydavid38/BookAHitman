/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Continental;

import java.util.Arrays;
import java.util.List;

/**
 *
 * @author Dávid
 */
public class HitmanRepository {
    private static HitmanRepository instance;
    
    public static HitmanRepository getInstance(){
        if(instance == null){
            instance = new HitmanRepository();
        }
        return instance;
    }
    
    List<Hitman> hList;

    public List<Hitman> gethList() {
        return hList;
    }

    public HitmanRepository() {
        Hitman h1 = new Hitman(1, "John Wick", "Martial Arts", 8000);
        Hitman h2 = new Hitman(2, "Marcus", "Sniper", 7000);
        Hitman h3 = new Hitman(3,"Ms. Perkins", "Martial Arts", 4500);
        Hitman h4 = new Hitman(4,"Harry", "Firearms", 2000);
        Hitman h5 = new Hitman(5,"Tick Tock Man", "Hobo", 500);
        Hitman h6 = new Hitman(6,"Zero", "Close Combat", 2000);
        Hitman h7 = new Hitman(7,"Ares", "Close Combat", 2500);
        Hitman h8 = new Hitman(8,"Cassian", "Martial Arts", 3700);
        Hitman h9 = new Hitman(9,"Wade Wilson", "Swords", 7500);
        Hitman h10 = new Hitman(8,"Floyd Lawton", "Firearms", 6600);
        Hitman h11 = new Hitman(8,"Jules Winnfield", "Firearms", 4500);
        Hitman h12 = new Hitman(8,"Arthur Bishop", "Close Combat", 5800);
        Hitman h13 = new Hitman(47,"", "Close Combat", 7000);
        
        hList = Arrays.asList(h1,h2,h3,h4,h5,h6,h7,h8,h9,h10,h11,h12,h13);
        
    }
    
}
