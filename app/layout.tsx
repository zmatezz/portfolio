import { Inter, IBM_Plex_Mono } from "next/font/google";
import "./globals.css";
import { ReactNode } from "react";
import { Header } from "./components/header";
import { ContactForm } from "./components/contact-form";
import { Footer } from "./components/footer";
import { BackToTop } from "./components/back-to-top";
import NextTopLoader from "nextjs-toploader";
import { Toaster } from "./components/toaster";

export const metadata = {
  title: {
    default: "Matheus Guedes | Portfolio <Desenvolvedor Web />",
    template: "%s | Matheus Guedes",
  },
  icons: [
    {
      url: "/favicon.svg",
    },
  ],
};

const inter = Inter({
  variable: "--font-inter",
  subsets: ["latin"],
});

const plexMono = IBM_Plex_Mono({
  variable: "--font-plex-mono",
  subsets: ["latin"],
  weight: ["400", "500"],
});

export default function RootLayout({ children }: { children: ReactNode }) {
  return (
    <html lang="pt-BR" className={`${inter.variable} ${plexMono.variable}`}>
      <body>
        <NextTopLoader color="linear-gradient(to right, rgb(239, 68, 68), rgb(153, 27, 27))" />
        <Toaster />
        <BackToTop />
        <Header />
        {children}
        <ContactForm />
        <Footer />
      </body>
    </html>
  );
}
