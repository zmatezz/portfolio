import { IoMdHeart } from "react-icons/io";

export const Footer = () => {
  return (
    <footer className="h-14 w-full flex items-center justify-center bg-gray-950">
      <span className="flex items-center gap-1.5 text-xs sm:text-sm font-poppins text-gray-400">
        Made with <IoMdHeart size={13} className="text-[#4271EB]" /> by
        <strong className="font-medium">zmatezz</strong>
      </span>
    </footer>
  );
};
