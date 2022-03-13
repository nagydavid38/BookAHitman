/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Continental;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;

/**
 *
 * @author Dávid
 */
@XmlRootElement
@XmlAccessorType(XmlAccessType.FIELD)
public class Hitman {
    
    @XmlElement
    int id;
    @XmlElement
    String name;
    @XmlElement
    String style;
    @XmlElement
    int price;
    public Hitman(){
        
    }
    public Hitman(int id, String name, String style, int price ){
        this.id = id;
        this.name = name;
        this.style = style;
        this.price = price;
    }

    public int getId() {
        return id;
    }

    public String getName() {
        return name;
    }

    public String getStyle() {
        return style;
    }

    public int getPrice() {
        return price;
    }
    
    
}
