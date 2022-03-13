/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Servlet;

import Continental.Filter;
import Continental.Hitman;
import Continental.HitmanList;
import Continental.HitmanRepository;
import java.io.IOException;
import java.io.PrintWriter;
import java.util.ArrayList;
import java.util.List;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.xml.bind.JAXBContext;
import javax.xml.bind.JAXBException;
import javax.xml.bind.Marshaller;

/**
 *
 * @author Dávid
 */
@WebServlet(name = "ContinentalServlet", urlPatterns = {"/ContinentalServlet"})
public class ContinentalServlet extends HttpServlet {

    /**
     * Processes requests for both HTTP <code>GET</code> and <code>POST</code>
     * methods.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    protected void processRequest(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        response.setContentType("text/xml;charset=UTF-8");
       Filter filter = new Filter();
       if(request.getParameter("price") != null && request.getParameter("price").trim() != ""){
           int price = Integer.parseInt(request.getParameter("price"));
           filter.setPriceFilter(price);
       }
       
       if(request.getParameter("style") != null && request.getParameter("style").trim() != ""){
           String style = request.getParameter("style");
           filter.setStyleFilter(style);
       }
       
       List<Hitman> hitmans = HitmanRepository.getInstance().gethList();
       
       HitmanList hList = new HitmanList(filter.Filter(hitmans));
       
       
       try{
           JAXBContext ctx = JAXBContext.newInstance(HitmanList.class, ArrayList.class);
           Marshaller marschaller = ctx.createMarshaller();
           marschaller.setProperty(Marshaller.JAXB_FORMATTED_OUTPUT, Boolean.TRUE);
           marschaller.marshal(hList, response.getOutputStream());
       } catch(JAXBException e){
           
       }
    }

    // <editor-fold defaultstate="collapsed" desc="HttpServlet methods. Click on the + sign on the left to edit the code.">
    /**
     * Handles the HTTP <code>GET</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    /**
     * Handles the HTTP <code>POST</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    /**
     * Returns a short description of the servlet.
     *
     * @return a String containing servlet description
     */
    @Override
    public String getServletInfo() {
        return "Short description";
    }// </editor-fold>

}
