/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Continental;

import java.util.List;
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
public class HitmanList {
    @XmlElement
    List<Hitman> hitmanList;
    
    public List<Hitman> getHitmanList(){
        return hitmanList;
    }
    public HitmanList(){
        
    }

    public HitmanList(List<Hitman> hList) {
        this.hitmanList = hList;
    }
    
}
