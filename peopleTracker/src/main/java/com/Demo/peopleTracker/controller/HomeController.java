package com.Demo.peopleTracker.controller;

import java.io.IOException;
import javax.servlet.http.HttpServletResponse;

import org.springframework.beans.factory.annotation.Value;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.client.RestTemplate;
import org.springframework.web.servlet.ModelAndView;

@Controller
public class HomeController {
	
	@Value("#{myProps['aboutUrl']}")
	private String aboutUrl;
	
	@Value("#{myProps['contactUrl']}")
	private String contactUrl;

	@RequestMapping(value="/")
	public ModelAndView index(HttpServletResponse response) throws IOException{
		return new ModelAndView("home");
	}
	
	@RequestMapping(value="/about")
	public ModelAndView about(HttpServletResponse response) throws IOException{
		return this.getMessage(aboutUrl, "about");
	}
	
	@RequestMapping(value="/contact")
	public ModelAndView contact(HttpServletResponse response) throws IOException{		
		return this.getMessage(contactUrl, "contact");
	}
	
	private ModelAndView getMessage(String url, String view)
	{
		RestTemplate restTemplate = new RestTemplate();
		String message = restTemplate.getForObject(url,  String.class);
		
		ModelAndView result = new ModelAndView(view);
		result.addObject("message", message.replace("\"", ""));
		result.addObject("aboutUrl", this.aboutUrl);
		result.addObject("contactUrl", this.contactUrl);
		return result;
	}
}
