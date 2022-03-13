/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Continental;

import java.io.StringWriter;
import java.util.ArrayList;
import java.util.List;
import javax.xml.bind.JAXBContext;
import javax.xml.bind.JAXBException;
import javax.xml.bind.Marshaller;

/**
 *
 * @author Dávid
 */
public class NewMain {
    public static void main(String[] args) throws JAXBException{
        Filter filter = new Filter();
        filter.setStyleFilter("e");
        
        List<Hitman> hitmans = HitmanRepository.getInstance().gethList();
        
        HitmanList hList = new HitmanList(filter.Filter(hitmans));
        
        JAXBContext ctx = JAXBContext.newInstance(HitmanList.class, ArrayList.class);
        Marshaller marschaller = ctx.createMarshaller();
        marschaller.setProperty(Marshaller.JAXB_FORMATTED_OUTPUT, Boolean.TRUE);
        StringWriter sw = new StringWriter();
        marschaller.marshal(hList, sw);
        System.out.println(sw.toString());
        System.out.println("hello");
    }
}
