/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Continental;

import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author Dávid
 */
public class Filter {
    boolean styleFilter;
    String subStringStyle;
    boolean priceFilter;
    int price;

    public Filter setStyleFilter(String style) {
        styleFilter = true;
        this.subStringStyle = style;
        return this;
    }

    public Filter setPriceFilter(int price) {
        priceFilter = true;
        this.price = price;
        return this;
    }
    public List<Hitman> Filter(List<Hitman> hList){
        List<Hitman> prefHitman = new ArrayList<Hitman>();
        
        for(Hitman h : hList){
            if((!styleFilter || h.getStyle().contains(this.subStringStyle))
                && (!priceFilter || h.getPrice() >= this.price)){
            prefHitman.add(h);
        }
    }
        return prefHitman;
    }
}
